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
    /// Interaction logic for addCategoryWindow.xaml
    /// </summary>
    public partial class addCategoryWindow : Window
    {
        private CategoryService categoryService = null;
        public addCategoryWindow()
        {
            InitializeComponent();
            this.categoryService = new CategoryService();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
