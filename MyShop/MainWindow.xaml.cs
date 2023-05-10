using Fluent;
using LiveCharts.Wpf;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using SERVICES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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
using Path = System.IO.Path;

namespace MyShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private ProductService productService;
        private OrderService orderService;
        public MainWindow()
        {
            InitializeComponent();
            productService = new ProductService();
            orderService = new OrderService();
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
            try
            {
                string appPath = AppDomain.CurrentDomain.BaseDirectory;
                string backupPath = Path.Combine(appPath, "Backup");
                if (!Directory.Exists(backupPath))
                {
                    Directory.CreateDirectory(backupPath);
                    DirectoryInfo dInfo = new DirectoryInfo(backupPath);
                    DirectorySecurity dSecurity = dInfo.GetAccessControl();
                    dSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                    dInfo.SetAccessControl(dSecurity);
                }

                string backupFile = Path.Combine(backupPath, "MyShop.bak");

                string conn = File.ReadAllText("Config.txt");

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "BACKUP DATABASE MyShop TO DISK= N'" + backupFile + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Database Backup thành công");
            }
            catch
            {
                MessageBox.Show("Error");
            }
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

        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlockSoLuongSanPham.Text = "" + productService.TongSoSp();
            TextBlockSoLuongDonHangTrongTuan.Text = "" + orderService.TongSoDonHangTuan();
            ProductsListView.ItemsSource = productService.SanPhamSapHetHang(5,5);
        }

        private void buttonRevenueProfit_Click(object sender, RoutedEventArgs e)
        {
            var screen = new ReportRevenueProfitWindow();
            screen.ShowDialog();
        }

        private void buttonReportProduct_Click(object sender, RoutedEventArgs e)
        {
            var screen = new ReportProductWindow();
            screen.ShowDialog();
        }

        private void buttonRestore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = "";
                var screen = new OpenFileDialog();
                if (screen.ShowDialog() == true)
                {
                    filePath = screen.FileName;
                    string databaseName = "MyShop";

                    string sqlRestore = $"USE master RESTORE DATABASE {databaseName} FROM DISK='{filePath}' WITH REPLACE;";

                    string conn = File.ReadAllText("Config.txt");

                    using (SqlConnection sqlCon = new SqlConnection(conn))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand(sqlRestore, sqlCon))
                        {
                            sqlCon.Open();
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Database Restore thành công");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
