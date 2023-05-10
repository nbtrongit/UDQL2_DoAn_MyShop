using ENTITIES;
using Microsoft.Win32;
using SERVICES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace MyShop
{
    /// <summary>
    /// Interaction logic for editProductWindow.xaml
    /// </summary>
    public partial class editProductWindow : Window
    {
        public Product data = null;
        private FileInfo _selectedImage = null;
        private ObservableCollection<Category> categories = null;
        private CategoryService categoryService = null;
        private ProductService productService = null;
        public editProductWindow(Product p)
        {
            InitializeComponent();
            this.data = p.Clone() as Product;
            this.categoryService = new CategoryService();
            this.productService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            categories = new ObservableCollection<Category>(categoryService.DanhSachCategory());

            categories.Add(new Category
            {
                Ten = "Null"
            });

            comboBoxCategories.ItemsSource = categories;
            foreach(var item in categories)
            {
                if(item.Id == data.LoaiSanPham)
                {
                    comboBoxCategories.SelectedItem = item;
                }
                else if (item.Id == 0 && comboBoxCategories.SelectedItem == null)
                {
                    comboBoxCategories.SelectedItem = item;
                }    
            }

            _selectedImage = new FileInfo(data.HinhAnh);
            textBoxTenSP.Text = data.Ten;
            textBoxGia.Text = ""+data.Gia;
            textBoxMoTa.Text = data.MoTa;
            textBoxHinhAnh.Text = ToolService.StringFolder(data.HinhAnh, "/", "/");
            textBoxSanXuat.Text = data.SanXuat;
            textBoxSoLuong.Text = ""+data.SoLuong;
            try
            {
                imageAnh.Source = new BitmapImage(new Uri($"{_selectedImage.FullName}", UriKind.Absolute));
            }
            catch
            {
                _selectedImage = new FileInfo($"{AppDomain.CurrentDomain.BaseDirectory}Data/Default/default-product-image - (none).png");
                imageAnh.Source = new BitmapImage(new Uri($"{AppDomain.CurrentDomain.BaseDirectory}Data/Default/default-product-image - (none).png", UriKind.Absolute));
            }

        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (ToolService.KiemTraSoNguyen(textBoxSoLuong.Text.Trim()) == false || ToolService.KiemTraSoNguyen(textBoxGia.Text.Trim()) == false || textBoxHinhAnh.Text == "")
            {
                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButton.OK);
            }
            else
            {
                var newProduct = new Product()
                {
                    Id = data.Id,
                    Ten = textBoxTenSP.Text.Trim(),
                    Gia = int.Parse(textBoxGia.Text),
                    MoTa = textBoxMoTa.Text.Trim(),
                    HinhAnh = $"Data/{textBoxHinhAnh.Text}/{_selectedImage.Name}",
                    LoaiSanPham = (comboBoxCategories.SelectedItem as Category).Id != 0 ? (comboBoxCategories.SelectedItem as Category).Id : null,
                    SanXuat = textBoxSanXuat.Text.Trim(),
                    SoLuong = int.Parse(textBoxSoLuong.Text)
                };
                if (productService.SuaProduct(newProduct))
                {
                    data = newProduct;
                    ToolService.CopyFile(textBoxHinhAnh.Text, _selectedImage);
                    MessageBox.Show("Sửa thành công", "Product", MessageBoxButton.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButton.OK);
                }
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonChonAnh_Click(object sender, RoutedEventArgs e)

        {
            var screen = new OpenFileDialog();
            if (screen.ShowDialog() == true)
            {
                _selectedImage = new FileInfo(screen.FileName);
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(screen.FileName, UriKind.Absolute);
                bitmap.EndInit();
                imageAnh.Source = bitmap;
            }
        }
    }
}
