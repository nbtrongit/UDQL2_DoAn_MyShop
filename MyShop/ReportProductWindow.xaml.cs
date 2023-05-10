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
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using SERVICES;

namespace MyShop
{
    /// <summary>
    /// Interaction logic for ReportProductWindow.xaml
    /// </summary>
    public partial class ReportProductWindow : Window
    {

        private ReportService reportService;
        private ProductService productService;
        public ReportProductWindow()
        {
            InitializeComponent();
            this.reportService = new ReportService();
            this.productService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            checkBoxNgay.IsChecked = true;
            chart.Series.Add(new ColumnSeries()
            {
                Title = "",
                Values = new ChartValues<int> { 0 }
            });

            chart.AxisX.Add(new Axis()
            {
                Labels = new string[] { "" }
            });
        }
        private void buttonReport_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxFirstDate.Text == "" || textBoxLastDate.Text == "" ||
                ToolService.KiemTraDate(textBoxFirstDate.Text) == false ||
                ToolService.KiemTraDate(textBoxLastDate.Text) == false ||
                ToolService.ConverDateToInt(ToolService.ConvertStringToDate(textBoxFirstDate.Text)) >
                ToolService.ConverDateToInt(ToolService.ConvertStringToDate(textBoxLastDate.Text))
                )
            {
                MessageBox.Show("Sai định dạng dữ liệu");
            }
            else
            {
                chart.AxisX.Clear();
                chart.Series.Clear();

                var products = productService.DanhSachProduct();

                if (checkBoxNgay.IsChecked == true)
                {
                    var labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 0);

                    for(int i = 0; i < products.Count; i++)
                    {
                        chart.Series.Add(new ColumnSeries()
                        {
                            Title = products[i].Ten,
                            Values = reportService.SoLuongSanPhamBan(labels, products[i].Id, 0)
                        });
                    }    

                    chart.AxisX.Add(new Axis()
                    {
                        Labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 0)
                    });
                }
                else if(checkBoxTuan.IsChecked == true)
                {
                    var labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 1);

                    for (int i = 0; i < products.Count; i++)
                    {
                        chart.Series.Add(new ColumnSeries()
                        {
                            Title = products[i].Ten,
                            Values = reportService.SoLuongSanPhamBan(labels, products[i].Id, 1)
                        });
                    }

                    chart.AxisX.Add(new Axis()
                    {
                        Labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 1)
                    });
                }
                else if (checkBoxThang.IsChecked == true)
                {
                    var labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 2);

                    for (int i = 0; i < products.Count; i++)
                    {
                        chart.Series.Add(new ColumnSeries()
                        {
                            Title = products[i].Ten,
                            Values = reportService.SoLuongSanPhamBan(labels, products[i].Id, 2)
                        });
                    }

                    chart.AxisX.Add(new Axis()
                    {
                        Labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 2)
                    });
                }
                else if (checkBoxNam.IsChecked == true)
                {
                    var labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 3);

                    for (int i = 0; i < products.Count; i++)
                    {
                        chart.Series.Add(new ColumnSeries()
                        {
                            Title = products[i].Ten,
                            Values = reportService.SoLuongSanPhamBan(labels, products[i].Id, 3)
                        });
                    }

                    chart.AxisX.Add(new Axis()
                    {
                        Labels = reportService.GetLabels(textBoxFirstDate.Text, textBoxLastDate.Text, 3)
                    });
                }
            }
        }

        private void textBoxLastDate_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxLastDate.Text = "";
            textBoxLastDate.Foreground = Brushes.Black;
        }

        private void textBoxFirstDate_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxFirstDate.Text = "";
            textBoxFirstDate.Foreground = Brushes.Black;
        }

        private void checkBoxNgay_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxNgay.IsChecked == false)
            {
                checkBoxNgay.IsChecked = true;
            }
            else
            {
                checkBoxThang.IsChecked = false;
                checkBoxNam.IsChecked = false;
                checkBoxTuan.IsChecked = false;
            }
        }

        private void checkBoxThang_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxThang.IsChecked == false)
            {
                checkBoxThang.IsChecked = true;
            }
            else
            {
                checkBoxNgay.IsChecked = false;
                checkBoxNam.IsChecked = false;
                checkBoxTuan.IsChecked = false;
            }
        }

        private void checkBoxNam_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxNam.IsChecked == false)
            {
                checkBoxNam.IsChecked = true;
            }
            else
            {
                checkBoxNgay.IsChecked = false;
                checkBoxThang.IsChecked = false;
                checkBoxTuan.IsChecked = false;
            }
        }

        private void checkBoxTuan_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxTuan.IsChecked == false)
            {
                checkBoxTuan.IsChecked = true;
            }
            else
            {
                checkBoxNgay.IsChecked = false;
                checkBoxThang.IsChecked = false;
                checkBoxNam.IsChecked = false;
            }
        }
    }
}
