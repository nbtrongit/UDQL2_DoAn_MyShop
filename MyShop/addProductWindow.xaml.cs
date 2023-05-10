using ENTITIES;
using Microsoft.Win32;
using SERVICES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.OleDb;
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
    /// Interaction logic for addProductWindow.xaml
    /// </summary>
    public partial class addProductWindow : Window
    {
        private FileInfo _selectedImage = null;
        private ObservableCollection<Category> categories = null;
        private CategoryService categoryService = null;
        private ProductService productService = null;
        public addProductWindow()
        {
            InitializeComponent();
            this.categoryService = new CategoryService();
            this.productService = new ProductService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            categories = new ObservableCollection<Category>(categoryService.DanhSachCategory());
            comboBoxCategories.ItemsSource = categories;
            _selectedImage = new FileInfo("Data/Default/default-product-image - (none).png");
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ToolService.KiemTraSoNguyen(textBoxSoLuong.Text.Trim()) == false || ToolService.KiemTraSoNguyen(textBoxGia.Text.Trim()) == false || textBoxHinhAnh.Text == "")
            {
                MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButton.OK);
            }
            else
            {
                Category loaisp = null;
                if(comboBoxCategories.SelectedItem != null)
                {
                    loaisp = comboBoxCategories.SelectedItem as Category;
                }

                var newProduct = new Product()
                {
                    Ten = textBoxTenSP.Text.Trim(),
                    Gia = int.Parse(textBoxGia.Text),
                    MoTa = textBoxMoTa.Text.Trim(),
                    HinhAnh = $"Data/{textBoxHinhAnh.Text}/{_selectedImage.Name}",
                    LoaiSanPham = loaisp != null ? loaisp.Id : null,
                    SanXuat = textBoxSanXuat.Text.Trim(),
                    SoLuong = int.Parse(textBoxSoLuong.Text)
                };
                if (productService.ThemProduct(newProduct))
                {
                    ToolService.CopyFile(textBoxHinhAnh.Text, _selectedImage);
                    MessageBox.Show("Thêm thành công", "Product", MessageBoxButton.OK);
                    this.Close();
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

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
