using ENTITIES;
using SERVICES;
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

namespace MyShop
{
    /// <summary>
    /// Interaction logic for editDetailOrderWindow.xaml
    /// </summary>
    public partial class editDetailOrderWindow : Window
    {
        private string madonhang { get; set; }
        private OrderService orderService = null;
        private List<Order> orders = null;
        public editDetailOrderWindow(string madh)
        {
            InitializeComponent();
            this.madonhang = madh;
            this.orderService = new OrderService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            orders = orderService.DanhSachOrderbyMaDonHang(madonhang);
            OrdersListView.ItemsSource = orders;
        }

        private void buttonDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            if(OrdersListView.SelectedItem != null)
            {
                if(orderService.XoaMotOrder(OrdersListView.SelectedItem as Order))
                {
                    MessageBox.Show("Xóa thành công", "Order", MessageBoxButton.OK);
                    orders = orderService.DanhSachOrderbyMaDonHang(madonhang);
                    OrdersListView.ItemsSource = orders;
                }
            }
        }


        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            if (orderService.XoaMotOrder(OrdersListView.SelectedItem as Order))
            {
                MessageBox.Show("Xóa thành công", "Order", MessageBoxButton.OK);
                orders = orderService.DanhSachOrderbyMaDonHang(madonhang);
                OrdersListView.ItemsSource = orders;
            }
        }

        private void editMenu_Click(object sender, RoutedEventArgs e)
        {
            var screen = new _editDetailOrderWindow(OrdersListView.SelectedItem as Order);
            screen.ShowDialog();
            orders = orderService.DanhSachOrderbyMaDonHang(madonhang);
            OrdersListView.ItemsSource = orders;
        }

        private void buttonEditOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersListView.SelectedItem != null)
            {
                var screen = new _editDetailOrderWindow(OrdersListView.SelectedItem as Order);
                screen.ShowDialog();
                orders = orderService.DanhSachOrderbyMaDonHang(madonhang);
                OrdersListView.ItemsSource = orders;
            }
        }
    }
}
