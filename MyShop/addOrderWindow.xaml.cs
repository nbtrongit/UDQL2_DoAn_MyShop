using ENTITIES;
using SERVICES;
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

namespace MyShop
{
    /// <summary>
    /// Interaction logic for addOrderWindow.xaml
    /// </summary>
    public partial class addOrderWindow : Window
    {
        private string madonhang { get; set; }
        private OrderService orderService = null;
        private ProductService productService = null;
        private ObservableCollection<Order> orders = null;
        private ObservableCollection<Product> products = null;
        public addOrderWindow(string madh)
        {
            InitializeComponent();
            this.madonhang = madh;
            this.orderService = new OrderService();
            this.productService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            orders = new ObservableCollection<Order>(orderService.DanhSachOrder());
            products = new ObservableCollection<Product>(productService.DanhSachProductConHang());

            if (orderService.KiemTraMaDonHang(madonhang.Trim()) == false)
            {
                textBoxMaDonHang.Text = madonhang;
            }
            else
            {
                textBoxMaDonHang.Text = madonhang;
                textBoxMaDonHang.IsReadOnly = true;
                foreach(var item in orders)
                {
                    if (item.MaDonHang == madonhang)
                    {
                        textBoxNgayDonHang.Text = $"{item.NgayDonHang.Day}/{item.NgayDonHang.Month}/{item.NgayDonHang.Year}";
                        textBoxNgayDonHang.IsReadOnly = true;
                        break;
                    }    
                }    
            }

            comboBoxProducts.ItemsSource = products;
            comboBoxProducts.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ToolService.KiemTraSoNguyen(textBoxSoLuong.Text) == false || ToolService.KiemTraSoNguyen(textBoxTriGia.Text) == false || ToolService.KiemTraDate(textBoxNgayDonHang.Text) == false)
            {
                MessageBox.Show("Thêm đơn hàng thất bại", "Lỗi", MessageBoxButton.OK);
            }
            else
            {
                var neworder = new Order()
                {
                    MaDonHang = textBoxMaDonHang.Text.Trim(),
                    SanPham = (comboBoxProducts.SelectedItem as Product).Id,
                    NgayDonHang = ToolService.ConvertStringToDate(textBoxNgayDonHang.Text),
                    SoLuong = int.Parse(textBoxSoLuong.Text),
                    ChiTiet = textBoxChiTiet.Text,
                    TriGia = int.Parse(textBoxTriGia.Text)
                };
                if(orderService.ThemOrder(neworder))
                {
                    MessageBox.Show("Thêm đơn hàng thành công", "Order", MessageBoxButton.OK);
                    DialogResult = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng không thành công", "Order", MessageBoxButton.OK);
                }
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
