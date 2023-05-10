using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Navigation;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ENTITIES;

namespace SERVICES
{
    public class ReportService
    {
        private ProductDAL product = null;
        private OrderDAL order = null;
        public ReportService()
        {
            this.product = new ProductDAL();
            this.order = new OrderDAL();
        }
        public List<string> GetLabels(string start, string end, int code)
        {
            List<string> result = new List<string>();
            if(code == 0)
            {
                DateTime startDate = DateTime.Parse(start);
                DateTime endDate = DateTime.Parse(end);
                List<DateTime> allDates = new List<DateTime>();
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    allDates.Add(date);
                }

                foreach(var item in allDates)
                {
                    result.Add($"{item.Day}/{item.Month}/{item.Year}");
                }    
            }

            else if(code == 1)
            {
                DateTime startDate = DateTime.Parse(start);
                DateTime endDate = DateTime.Parse(end);
                int days = (int)(endDate - startDate).TotalDays + 1;
                for (int i = 0; i < days; i += 7)
                {
                    DateTime rangeStart = startDate.AddDays(i);
                    DateTime rangeEnd = rangeStart.AddDays(7 - 1);
                    if (rangeEnd > endDate)
                    {
                        rangeEnd = endDate;
                    }
                    string rangeString = $"{rangeStart:d/M/yyyy}-{rangeEnd:d/M/yyyy}";
                    result.Add(rangeString);
                }
            }    

            else if (code == 2)
            {
                DateTime startDate = DateTime.Parse(start);
                DateTime endDate = DateTime.Parse(end);
                while (startDate <= endDate)
                {
                    DateTime chunkEnd = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));
                    if (chunkEnd > endDate)
                    {
                        chunkEnd = endDate;
                    }
                    result.Add(startDate.ToString("d/M/yyyy") + "-" + chunkEnd.ToString("d/M/yyyy"));
                    startDate = chunkEnd.AddDays(1);
                }
            }
            else if (code == 3)
            {
                DateTime startDate = DateTime.Parse(start);
                DateTime endDate = DateTime.Parse(end);
                result.Add(startDate.ToString("d/M/yyyy") + "-" + new DateTime(startDate.Year, 12, 31).ToString("d/M/yyyy"));
                for (int year = startDate.Year + 1; year < endDate.Year; year++)
                {
                    result.Add(new DateTime(year, 1, 1).ToString("d/M/yyyy") + "-" + new DateTime(year, 12, 31).ToString("d/M/yyyy"));
                }
                result.Add(new DateTime(endDate.Year, 1, 1).ToString("d/M/yyyy") + "-" + endDate.ToString("d/M/yyyy"));
            }
            return result;
        }

        public ChartValues<int> DoanhThu(string start, string end, int code)
        {
            var result = new ChartValues<int>();
            if(code == 0)
            {
                var labels = GetLabels(start, end, 0);
                var orders = order.DanhSachOrder();
                foreach(var item in labels)
                {
                    var count = 0;
                    foreach (var i in orders)
                    {
                        if (ToolService.ConverDateToInt(i.NgayDonHang) == ToolService.ConvertStringDateToInt(item))
                        {
                            count += i.TriGia;
                        }    
                    }
                    result.Add(count);
                }     
            }
            else if (code == 1)
            {
                var labels = GetLabels(start, end, 1);
                var orders = order.DanhSachOrder();
                foreach (var item in labels)
                {
                    string[] temp = item.Split('-');
                    DateTime startDate = DateTime.Parse(temp[0]);
                    DateTime endDate = DateTime.Parse(temp[1]);
                    var count = 0;
                    foreach (var i in orders)
                    {
                        if (ToolService.ConverDateToInt(i.NgayDonHang) >= ToolService.ConverDateToInt(startDate) && (ToolService.ConverDateToInt(i.NgayDonHang) <= ToolService.ConverDateToInt(endDate)))
                        {
                            count += i.TriGia;
                        }
                    }
                    result.Add(count);
                }
            }
            else if (code == 2)
            {
                var labels = GetLabels(start, end, 2);
                var orders = order.DanhSachOrder();
                foreach (var item in labels)
                {
                    string[] temp = item.Split('-');
                    DateTime startDate = DateTime.Parse(temp[0]);
                    DateTime endDate = DateTime.Parse(temp[1]);
                    var count = 0;
                    foreach (var i in orders)
                    {
                        if (ToolService.ConverDateToInt(i.NgayDonHang) >= ToolService.ConverDateToInt(startDate) && (ToolService.ConverDateToInt(i.NgayDonHang) <= ToolService.ConverDateToInt(endDate)))
                        {
                            count += i.TriGia;
                        }
                    }
                    result.Add(count);
                }
            }
            else if (code == 3)
            {
                var labels = GetLabels(start, end, 3);
                var orders = order.DanhSachOrder();
                foreach (var item in labels)
                {
                    string[] temp = item.Split('-');
                    DateTime startDate = DateTime.Parse(temp[0]);
                    DateTime endDate = DateTime.Parse(temp[1]);
                    var count = 0;
                    foreach (var i in orders)
                    {
                        if (ToolService.ConverDateToInt(i.NgayDonHang) >= ToolService.ConverDateToInt(startDate) && (ToolService.ConverDateToInt(i.NgayDonHang) <= ToolService.ConverDateToInt(endDate)))
                        {
                            count += i.TriGia;
                        }
                    }
                    result.Add(count);
                }
            }
            return result;
        }

        public ChartValues<int> LoiNhuan(string start, string end, int code)
        {
            var result = new ChartValues<int>();
            if (code == 0)
            {
                var labels = GetLabels(start, end, 0);
                var orders = order.DanhSachOrder();
                var products = product.DanhSachProduct();
                foreach (var item in labels)
                {
                    var count = 0;
                    foreach (var o in orders)
                    {
                        if (ToolService.ConverDateToInt(o.NgayDonHang) == ToolService.ConvertStringDateToInt(item))
                        {
                            foreach (var p in products)
                            {
                                if(p.Id == o.SanPham)
                                {
                                    count += o.TriGia - p.Gia;
                                }    
                            }    
                        }
                    }
                    result.Add(count);
                }
            }
            else if (code == 1)
            {
                var labels = GetLabels(start, end, 1);
                var orders = order.DanhSachOrder();
                var products = product.DanhSachProduct();
                foreach (var item in labels)
                {
                    string[] temp = item.Split('-');
                    DateTime startDate = DateTime.Parse(temp[0]);
                    DateTime endDate = DateTime.Parse(temp[1]);
                    var count = 0;
                    foreach (var o in orders)
                    {
                        if (ToolService.ConverDateToInt(o.NgayDonHang) >= ToolService.ConverDateToInt(startDate) && (ToolService.ConverDateToInt(o.NgayDonHang) <= ToolService.ConverDateToInt(endDate)))
                        {
                            foreach (var p in products)
                            {
                                if (p.Id == o.SanPham)
                                {
                                    count += o.TriGia - p.Gia;
                                }
                            }
                        }
                    }
                    result.Add(count);
                }
            }
            else if (code == 2)
            {
                var labels = GetLabels(start, end, 2);
                var orders = order.DanhSachOrder();
                var products = product.DanhSachProduct();
                foreach (var item in labels)
                {
                    string[] temp = item.Split('-');
                    DateTime startDate = DateTime.Parse(temp[0]);
                    DateTime endDate = DateTime.Parse(temp[1]);
                    var count = 0;
                    foreach (var o in orders)
                    {
                        if (ToolService.ConverDateToInt(o.NgayDonHang) >= ToolService.ConverDateToInt(startDate) && (ToolService.ConverDateToInt(o.NgayDonHang) <= ToolService.ConverDateToInt(endDate)))
                        {
                            foreach (var p in products)
                            {
                                if (p.Id == o.SanPham)
                                {
                                    count += o.TriGia - p.Gia;
                                }
                            }
                        }
                    }
                    result.Add(count);
                }
            }
            else if (code == 3)
            {
                var labels = GetLabels(start, end, 3);
                var orders = order.DanhSachOrder();
                var products = product.DanhSachProduct();
                foreach (var item in labels)
                {
                    string[] temp = item.Split('-');
                    DateTime startDate = DateTime.Parse(temp[0]);
                    DateTime endDate = DateTime.Parse(temp[1]);
                    var count = 0;
                    foreach (var o in orders)
                    {
                        if (ToolService.ConverDateToInt(o.NgayDonHang) >= ToolService.ConverDateToInt(startDate) && (ToolService.ConverDateToInt(o.NgayDonHang) <= ToolService.ConverDateToInt(endDate)))
                        {
                            foreach (var p in products)
                            {
                                if (p.Id == o.SanPham)
                                {
                                    count += o.TriGia - p.Gia;
                                }
                            }
                        }
                    }
                    result.Add(count);
                }
            }
            return result;
        }
    }
}
