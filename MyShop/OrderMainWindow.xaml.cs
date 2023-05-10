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
    /// Interaction logic for OrderMainWindow.xaml
    /// </summary>
    public partial class OrderMainWindow : Window
    {
        private ProductService productService = null;
        private ObservableCollection<Order> orders = null;
        private OrderService orderService = null;
        int _currentPage;
        int _rowsPerPage;
        int _totalItems = 0;
        int _totalPages = 0;
        string first;
        string last;
        public int RowsPerPage { get => _rowsPerPage; set => _rowsPerPage = value; }
        public int TotalItems { get => _totalItems; set => _totalItems = value; }
        public OrderMainWindow()
        {
            InitializeComponent();
            this.orderService = new OrderService();
            this.productService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (productService.DanhSachProduct().Count == 0)
            {
                MessageBox.Show("Không có sản phẩm", "Order", MessageBoxButton.OK);
                this.Close();
            }    

            _currentPage = 1;
            RowsPerPage = 10;
            first = "";
            last = "";

            (orders, TotalItems) = orderService.GetAll(_currentPage, _rowsPerPage, first, last);
            OrdersListView.ItemsSource = orders;
            _updatePagingInfo();
            pagingComboBox.SelectedIndex = 0;
        }

        #region function
        void _updatePagingInfo()
        {
            _totalPages = TotalItems / RowsPerPage + (TotalItems % RowsPerPage == 0 ? 0 : 1);

            var lines = new List<Tuple<int, int>>();

            for (int i = 1; i <= _totalPages; i++)
            {
                lines.Add(new Tuple<int, int>(i, _totalPages));
            }

            pagingComboBox.ItemsSource = lines;
        }
        void _updateDataSource()
        {
            (orders, TotalItems) = orderService.GetAll(_currentPage, RowsPerPage, first, last);
            OrdersListView.ItemsSource = orders;
        }
        #endregion


        private void buttonFilterDate_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxFirstDate.Text == "" || textBoxLastDate.Text =="")
            {
                first = textBoxFirstDate.Text;
                last = textBoxLastDate.Text;
                _updateDataSource();
                _updatePagingInfo();
                pagingComboBox.SelectedIndex = 0;
            }
            else
            {
                if (ToolService.KiemTraDate(textBoxFirstDate.Text) == false || ToolService.KiemTraDate(textBoxLastDate.Text) == false)
                {
                    MessageBox.Show("Sai định dạng ngày", "Lỗi", MessageBoxButton.OK);
                }
                else
                {
                    first = textBoxFirstDate.Text;
                    last = textBoxLastDate.Text;
                    _updateDataSource();
                    _updatePagingInfo();
                    pagingComboBox.SelectedIndex = 0;
                }
            }
        }

        private void buttonUpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            if(OrdersListView.SelectedItem != null)
            {
                var screen = new editOrderWindow(OrdersListView.SelectedItem as Order);
                if (screen.ShowDialog() == true)
                {
                    _updateDataSource();
                    _updatePagingInfo();
                    pagingComboBox.SelectedIndex = 0;
                }
            }
        }

        private void buttonDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            if(OrdersListView.SelectedItem != null)
            {
                if (orderService.XoaOrder(OrdersListView.SelectedItem as Order))
                {
                    MessageBox.Show("Xóa thành công", "Order", MessageBoxButton.OK);
                    _updateDataSource();
                    _updatePagingInfo();
                    pagingComboBox.SelectedIndex = 0;
                }
            }    
        }

        private void buttonAddOrder_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxNewOrder.Visibility == Visibility.Hidden)
            {
                textBoxNewOrder.Visibility = Visibility.Visible;
            }
            else
            {
                if (textBoxNewOrder.Text != "Nhập mã đơn hàng" || textBoxNewOrder.Text != "")
                {
                    var screen = new addOrderWindow(textBoxNewOrder.Text);
                    if(screen.ShowDialog() == true)
                    {
                        _updateDataSource();
                        _updatePagingInfo();
                        pagingComboBox.SelectedIndex = 0;
                        textBoxNewOrder.Visibility = Visibility.Hidden;
                        textBoxNewOrder.Text = "Nhập mã đơn hàng";
                        textBoxNewOrder.Foreground = Brushes.Gray;
                    }
                    else
                    {
                        textBoxNewOrder.Visibility = Visibility.Hidden;
                        textBoxNewOrder.Text = "Nhập mã đơn hàng";
                        textBoxNewOrder.Foreground = Brushes.Gray;
                    }
                }
            }
        }

        private void pagingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = pagingComboBox.SelectedIndex;
            if (i >= 0)
            {
                _currentPage = i + 1;
                _updateDataSource();
            }
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersListView.SelectedItem != null)
            {
                if (orderService.XoaOrder(OrdersListView.SelectedItem as Order))
                {
                    MessageBox.Show("Xóa thành công", "Order", MessageBoxButton.OK);
                    _updateDataSource();
                    _updatePagingInfo();
                    pagingComboBox.SelectedIndex = 0;
                }
            }
        }

        private void editMenu_Click(object sender, RoutedEventArgs e)
        {
            var screen = new editDetailOrderWindow((OrdersListView.SelectedItem as Order).MaDonHang);
            if (screen.ShowDialog() == true)
            {
                _updateDataSource();
                _updatePagingInfo();
                pagingComboBox.SelectedIndex = 0;
            }
        }

        private void listViewItem_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var screen = new detailOrderWindow(OrdersListView.SelectedItem as Order);
            screen.ShowDialog();
        }

        private void buttonPrev_Click(object sender, RoutedEventArgs e)
        {
            int i = pagingComboBox.SelectedIndex;
            if (i > 0)
            {
                pagingComboBox.SelectedIndex = i - 1;
            }
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            int i = pagingComboBox.SelectedIndex;
            if (i < (_totalPages - 1))
            {
                pagingComboBox.SelectedIndex = i + 1;
            }
        }

        private void textBoxFirstDate_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxFirstDate.Text = "";
            textBoxFirstDate.Foreground = Brushes.Black;
        }

        private void textBoxLastDate_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxLastDate.Text = "";
            textBoxLastDate.Foreground = Brushes.Black;
        }

        private void textBoxNewOrder_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxNewOrder.Text = "";
            textBoxNewOrder.Foreground = Brushes.Black;
        }
    }
}
