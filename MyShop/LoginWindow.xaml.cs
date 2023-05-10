using ENTITIES;
using Microsoft.Win32;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UserService user = null;
        public LoginWindow()
        {
            InitializeComponent();
            user = new UserService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ToolService.KiemTraKetNoi() == false)
            {
                MessageBox.Show("Kết nối Database thất bại", "Lỗi", MessageBoxButton.OK);
                this.Close();
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyShopSettings");
                if (key == null)
                {
                    ToolService.TaoRegistry();
                }
                else
                {
                    if ((string)key.GetValue("Check") == "1")
                    {
                        textBoxUsername.Text = (string)key.GetValue("Username");
                        passwordBox.Password = ToolService.Decode((string)key.GetValue("Password"), (string)key.GetValue("Entropy"));
                        key.Close();
                        checkBoxRemember.IsChecked = true;
                    }
                }
            }
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {

            if (user.KiemTraUser(textBoxUsername.Text, passwordBox.Password))
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyShopSettings", true);

                if (checkBoxRemember.IsChecked == true)
                {
                    key.SetValue("Check", "1");
                    key.SetValue("Username", textBoxUsername.Text);
                    ToolService.Encode(passwordBox.Password);
                    key.Close();
                }
                else
                {
                    key.SetValue("Check", "0");
                    key.SetValue("Username", "");
                    key.SetValue("Password", "");
                    key.Close();
                }

                var screen = new MainWindow();
                this.Close();
                MessageBox.Show("Đăng nhập thành công", "Login", MessageBoxButton.OK);
                screen.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Login", MessageBoxButton.OK);
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
