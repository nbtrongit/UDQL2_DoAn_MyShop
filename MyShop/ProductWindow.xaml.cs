using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ENTITIES;
using SERVICES;

namespace MyShop
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private ObservableCollection<Product> products = null;
        private ProductService productService = null;
        private ObservableCollection<Category> categories = null;
        private CategoryService categoryService = null;
        int _currentPage;
        int _rowsPerPage;
        int _totalItems = 0;
        int _totalPages = 0;
        string _keyword;
        int _minPrice;
        int _maxPrice;
        int _categoryId;
        public int RowsPerPage { get => _rowsPerPage; set => _rowsPerPage = value; }
        public string Keyword { get => _keyword; set => _keyword = value; }
        public int TotalItems { get => _totalItems; set => _totalItems = value; }
        public int MinPrice { get => _minPrice; set => _minPrice = value; }
        public int MaxPrice { get => _maxPrice; set => _maxPrice = value; }
        public ProductWindow()
        {
            InitializeComponent();
            this.productService = new ProductService();
            this.categoryService = new CategoryService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rowsPerPageTextBox.DataContext = this;
            keywordTextBox.DataContext = this;
            rowsPerPageRun.DataContext = this;
            totalItemsRun.DataContext = this;
            minTextBox.DataContext = this;
            maxTextBox.DataContext = this;

            categories = new ObservableCollection<Category>(categoryService.DanhSachCategory());
            categories.Add(new Category { Ten = "Loại Sản Phẩm" });

            _currentPage = 1;
            RowsPerPage = 10;
            MinPrice = 0;
            MaxPrice = productService.MaxPriceProduct();
            Keyword = "";
            _categoryId = 0;

            (products, TotalItems) = productService.GetAll(_currentPage, RowsPerPage, Keyword, MinPrice, MaxPrice, _categoryId);
            ProductsListView.ItemsSource = products;
            _updatePagingInfo();
            pagingComboBox.SelectedIndex = 0;
            foreach (var item in categories)
            {
                if (item.Id == 0)
                {
                    comboBoxCategories.SelectedItem = item;
                }
            }
            comboBoxCategories.ItemsSource = categories;
        }

        #region function
        void _updatePagingInfo()
        {
            _totalPages = TotalItems / RowsPerPage + (TotalItems % RowsPerPage == 0 ? 0 : 1);

            var lines = new List<Tuple<int, int>>();

            for (int i = 1; i <= _totalPages; i++)
            {
                lines.Add(new Tuple<int, int>(i, _totalPages));
            }

            pagingComboBox.ItemsSource = lines;
        }
        void _updateDataSource()
        {
            (products, TotalItems) = productService.GetAll(_currentPage, RowsPerPage, Keyword, MinPrice, MaxPrice, _categoryId);
            ProductsListView.ItemsSource = products;
        }
        #endregion
        private void listViewItem_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var screen = new detailProductWindow(ProductsListView.SelectedItem as Product);
            screen.ShowDialog();
        }

        private void editMenu_Click(object sender, RoutedEventArgs e)
        {
            var screen = new editProductWindow(ProductsListView.SelectedItem as Product);
            screen.ShowDialog();
            foreach (var item in products)
            {
                if (item.Id == screen.data.Id)
                {
                    item.Id = screen.data.Id;
                    item.Ten = screen.data.Ten;
                    item.Gia = screen.data.Gia;
                    item.MoTa = screen.data.MoTa;
                    item.HinhAnh = screen.data.HinhAnh;
                    item.LoaiSanPham = screen.data.LoaiSanPham;
                    item.SanXuat = screen.data.SanXuat;
                    item.SoLuong = screen.data.SoLuong;
                    break;
                }
            }
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            if (productService.XoaProduct(ProductsListView.SelectedItem as Product))
            {
                MessageBox.Show("Xóa thành công", "Delete", MessageBoxButton.OK);
                _updateDataSource();
                _updatePagingInfo();
                pagingComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButton.OK);
            }
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new addProductWindow();
            screen.ShowDialog();
            MinPrice = 0;
            minTextBox.Text = "0";
            MaxPrice = productService.MaxPriceProduct();
            maxTextBox.Text = "" + MaxPrice;
            Keyword = "";
            keywordTextBox.Text = "";
            _categoryId = 0;
            _updateDataSource();
            _updatePagingInfo();
            pagingComboBox.SelectedIndex = 0;
            if (RowsPerPage > products.Count)
            {
                rowsPerPageRun.Text = "" + products.Count;
            }
            else
            {
                rowsPerPageRun.Text = "" + RowsPerPage;
            }
        }

        private void deleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (productService.XoaProduct(ProductsListView.SelectedItem as Product))
            {
                MessageBox.Show("Xóa thành công", "Delete", MessageBoxButton.OK);
                _updateDataSource();
                _updatePagingInfo();
                pagingComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButton.OK);
            }
        }

        private void updateProductButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new editProductWindow(ProductsListView.SelectedItem as Product);
            screen.ShowDialog();
            foreach (var item in products)
            {
                if (item.Id == screen.data.Id)
                {
                    item.Id = screen.data.Id;
                    item.Ten = screen.data.Ten;
                    item.Gia = screen.data.Gia;
                    item.MoTa = screen.data.MoTa;
                    item.HinhAnh = screen.data.HinhAnh;
                    item.LoaiSanPham = screen.data.LoaiSanPham;
                    item.SanXuat = screen.data.SanXuat;
                    item.SoLuong = screen.data.SoLuong;
                    break;
                }
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            _updateDataSource();
            _updatePagingInfo();
            pagingComboBox.SelectedIndex = 0;
        }

        private void updateRowPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (RowsPerPage > 0)
            {
                MinPrice = 0;
                minTextBox.Text = "0";
                MaxPrice = productService.MaxPriceProduct();
                maxTextBox.Text = ""+MaxPrice;
                Keyword = "";
                keywordTextBox.Text = "";
                _categoryId = 0;
                _updateDataSource();
                _updatePagingInfo();
                pagingComboBox.SelectedIndex = 0;
                if(RowsPerPage > products.Count)
                {
                    rowsPerPageRun.Text = "" + products.Count;
                }
                else
                {
                    rowsPerPageRun.Text = "" + RowsPerPage;
                }
            }
        }

        private void pagingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = pagingComboBox.SelectedIndex;
            if (i >= 0)
            {
                _currentPage = i + 1;
                _updateDataSource();
            }
        }

        private void prevButton_Click(object sender, RoutedEventArgs e)
        {
            int i = pagingComboBox.SelectedIndex;
            if (i > 0)
            {
                pagingComboBox.SelectedIndex = i - 1;
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            int i = pagingComboBox.SelectedIndex;
            if (i < (_totalPages - 1))
            {
                pagingComboBox.SelectedIndex = i + 1;
            }
        }

        private void filterPriceButton_Click(object sender, RoutedEventArgs e)
        {
            if (MaxPrice >= MinPrice)
            {
                _updateDataSource();
                _updatePagingInfo();
                pagingComboBox.SelectedIndex = 0;
            }
        }

        private void comboBoxCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _categoryId = (comboBoxCategories.SelectedItem as Category).Id;
            _updateDataSource();
            _updatePagingInfo();
            pagingComboBox.SelectedIndex = 0;
        }
    }
}
