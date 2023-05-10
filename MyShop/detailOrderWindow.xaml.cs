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
    /// Interaction logic for detailOrderWindow.xaml
    /// </summary>
    public partial class detailOrderWindow : Window
    {
        public Order data { get; set; }
        private ProductService productService = null;
        private ObservableCollection<Product> products = null;
        public detailOrderWindow(Order d)
        {
            InitializeComponent();
            data = d.Clone() as Order;
            this.productService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            products = new ObservableCollection<Product>(productService.GetProductByMaDonHang(data.MaDonHang));
            ProductsListView.ItemsSource = products;
            this.DataContext = data;
        }
    }
}
