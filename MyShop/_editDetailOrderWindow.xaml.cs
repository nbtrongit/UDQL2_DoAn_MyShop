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
    /// Interaction logic for _editDetailOrderWindow.xaml
    /// </summary>
    public partial class _editDetailOrderWindow : Window
    {
        private Order oldO { get; set; }
        private List<Product> products = null;
        private ProductService productService = null;
        private OrderService orderService = null;
        public _editDetailOrderWindow(Order oR)
        {
            InitializeComponent();
            this.oldO = oR.Clone() as Order;
            this.productService = new ProductService();
            this.orderService = new OrderService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxMaDonHang.Text = oldO.MaDonHang;
            textBoxMaDonHang.IsReadOnly = true;
            textBoxNgayDonHang.Text = $"{oldO.NgayDonHang.Day}/{oldO.NgayDonHang.Month}/{oldO.NgayDonHang.Year}";
            textBoxNgayDonHang.IsReadOnly = true;

            products = productService.DanhSachProductConHang();
            comboBoxProducts.ItemsSource = products;
            foreach(var item in products)
            {
                if(item.Id == oldO.SanPham)
                {
                    comboBoxProducts.SelectedItem = item;
                    break;
                }    
            }    

            textBoxSoLuong.Text = "" + oldO.SoLuong;
            textBoxChiTiet.Text = oldO.ChiTiet;
            textBoxTriGia.Text = ""+oldO.TriGia;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if(ToolService.KiemTraSoNguyen(textBoxSoLuong.Text) == false || ToolService.KiemTraSoNguyen(textBoxTriGia.Text) == false)
            {
                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButton.OK);
            }
            else
            {
                var newO = oldO.Clone() as Order;
                newO.SoLuong = int.Parse(textBoxSoLuong.Text);
                newO.TriGia = int.Parse(textBoxTriGia.Text);
                newO.ChiTiet = textBoxChiTiet.Text;
                newO.SanPham = (comboBoxProducts.SelectedItem as Product).Id;

                if(orderService.SuaMotOrder(oldO, newO))
                {
                    MessageBox.Show("Sửa thành công", "Lỗi", MessageBoxButton.OK);
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
    }
}
