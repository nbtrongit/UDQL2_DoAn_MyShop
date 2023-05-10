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
        public ProductWindow()
        {
            InitializeComponent();
            this.productService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            products = new ObservableCollection<Product>(productService.DanhSachProduct());
            ProductsListView.ItemsSource = products;
        }

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
            if(productService.XoaProduct(ProductsListView.SelectedItem as Product))
            {
                MessageBox.Show("Xóa thành công", "Delete", MessageBoxButton.OK);
                products = new ObservableCollection<Product>(productService.DanhSachProduct());
                ProductsListView.ItemsSource = products;
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
            products = new ObservableCollection<Product>(productService.DanhSachProduct());
            ProductsListView.ItemsSource = products;
        }

        private void deleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (productService.XoaProduct(ProductsListView.SelectedItem as Product))
            {
                MessageBox.Show("Xóa thành công", "Delete", MessageBoxButton.OK);
                products = new ObservableCollection<Product>(productService.DanhSachProduct());
                ProductsListView.ItemsSource = products;
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

        }

        private void updateRowPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pagingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void prevButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
