using ENTITIES;
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
    /// Interaction logic for detailProductWindow.xaml
    /// </summary>
    public partial class detailProductWindow : Window
    {
        private Product product = null;
        public detailProductWindow(Product p)
        {
            InitializeComponent();
            this.product = p;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = product;
        }
    }
}
