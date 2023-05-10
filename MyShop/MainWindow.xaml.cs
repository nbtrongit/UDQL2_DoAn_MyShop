using Fluent;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, RoutedEventArgs e)
        {
            if(ToolService.ImportAccess())
            {
                MessageBox.Show("Import dữ liệu thành công", "Import", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Import lỗi (database không trống/lỗi khác)", "Lỗi", MessageBoxButton.OK);
            }
        }

        private void buttonBackup_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonCategory_Click(object sender, RoutedEventArgs e)
        {
            var screen = new CategoryWindow();
            screen.ShowDialog();
        }

        private void buttonProduct_Click(object sender, RoutedEventArgs e)
        {
            var screen = new ProductWindow();
            screen.ShowDialog();
        }

        private void buttonOrder_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OrderMainWindow();
            screen.ShowDialog();
        }

        private void BackstageTabItem_MouseDown_Import(object sender, MouseButtonEventArgs e)
        {
            if (ToolService.ImportAccess())
            {
                MessageBox.Show("Import dữ liệu thành công", "Import", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Import lỗi (database không trống/lỗi khác)", "Lỗi", MessageBoxButton.OK);
            }
        }

        private void BackstageTabItem_MouseDown_Exit(object sender, MouseButtonEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Tắt chương trình", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                this.Close();
            }
        }

        private void buttonCategory_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void buttonProduct_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOrder_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
