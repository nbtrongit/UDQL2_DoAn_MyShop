using System;
using System.Collections.Generic;
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
    /// Interaction logic for editOrderWindow.xaml
    /// </summary>
    public partial class editOrderWindow : Window
    {
        private Order oldOrder { get; set; }
        private OrderService orderService = null;
        public editOrderWindow(Order dh)
        {
            InitializeComponent();
            this.oldOrder = dh.Clone() as Order;
            this.orderService = new OrderService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxMaDonHang.Text = oldOrder.MaDonHang;
            textBoxNgayDonHang.Text = $"{oldOrder.NgayDonHang.Day}/{oldOrder.NgayDonHang.Month}/{oldOrder.NgayDonHang.Year}";
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxMaDonHang.Text == "" || ToolService.KiemTraDate(textBoxNgayDonHang.Text) == false)
            {
                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButton.OK);
            }
            else
            {
                var newO = new Order()
                {
                    MaDonHang = textBoxMaDonHang.Text,
                    NgayDonHang = ToolService.ConvertStringToDate(textBoxNgayDonHang.Text)
                };
                if(orderService.SuaOrder(oldOrder, newO))
                {
                    DialogResult = true;
                    MessageBox.Show("Sửa thành công", "Order", MessageBoxButton.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Order", MessageBoxButton.OK);
                }    
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
