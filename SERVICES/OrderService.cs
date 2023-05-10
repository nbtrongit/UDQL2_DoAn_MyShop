using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SERVICES
{
    public class OrderService
    {
        private ProductDAL product = null;
        private OrderDAL order = null;
        private ProductService productService = null;
        public OrderService() 
        {
            this.product = new ProductDAL();
            this.order = new OrderDAL();
            this.productService = new ProductService();
        }
        public List<Order> DanhSachOrder()
        {
            return order.DanhSachOrder();
        }

        public List<Order> DanhSachOrderbyMaDonHang(string madh)
        {
            var ds = order.DanhSachOrder();
            return ds.Where(x => x.MaDonHang == madh).ToList();
        }
        public Tuple<ObservableCollection<Order>, int> GetAll(int page, int itemsPerPage, string first, string last)
        {
            var ds = order.DanhSachOrder();
            ds = ds.GroupBy(x => x.MaDonHang)
                .Select(g => new Order{ MaDonHang = g.Key, SoLuong = g.Sum(x => x.SoLuong), TriGia = g.Sum(x => x.TriGia), NgayDonHang = g.FirstOrDefault().NgayDonHang, ChiTiet = string.Concat(g.Select(x => x.ChiTiet))})
                .ToList();  

            if (first == "" || last == "")
            {
                var result = ds
                    .Skip((page - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .ToList();
                return new Tuple<ObservableCollection<Order>, int>(new ObservableCollection<Order>(result), ds.Count());
            }
            else
            {
                var firstDate = ToolService.ConvertStringToDate(first);
                var lastDate = ToolService.ConvertStringToDate(last);

                var query = ds.Where(item => (DateTime.Compare(item.NgayDonHang, firstDate) == 0 || DateTime.Compare(item.NgayDonHang, firstDate) == 1) && (DateTime.Compare(item.NgayDonHang, lastDate) == 0 || DateTime.Compare(item.NgayDonHang, lastDate) == -1));
                var result = query
                    .Skip((page - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .ToList();
                return new Tuple<ObservableCollection<Order>, int>(new ObservableCollection<Order>(result), query.Count());
            }
        }

        public bool KiemTraMaDonHang(string madh)
        {
            var ds = order.DanhSachOrder();

            foreach(var item in ds)
            {
                if (item.MaDonHang == madh)
                {
                    return true;
                }    
            }    

            return false;
        }
        public bool ThemOrder(Order newO)
        {
            var temp = productService.ProductById(newO.SanPham);
            if (temp.SoLuong - newO.SoLuong < 0)
            {
                return false;
            }
            temp.SoLuong = temp.SoLuong - newO.SoLuong;
            product.SuaProduct(temp);
            order.ThemOrder(newO);
            return true;
        }

        public bool XoaOrder(Order del)
        {
            var ds = order.DanhSachOrder();
            ds = ds.Where(x => x.MaDonHang == del.MaDonHang).ToList();
            foreach (var item in ds)
            {
                var temp = productService.ProductById(item.SanPham);
                temp.SoLuong = temp.SoLuong + item.SoLuong;
                productService.SuaProduct(temp);
            }
            order.XoaOrder(ds);
            return true;
        }

        public bool XoaMotOrder(Order del)
        {
            var p = productService.ProductById(del.SanPham);
            p.SoLuong += del.SoLuong;
            productService.SuaProduct(p);
            order.XoaMotOrder(del);
            return true;
        }
        public bool SuaOrder(Order oldO, Order newO)
        {
            if (oldO.MaDonHang != newO.MaDonHang)
            {
                var ds = order.DanhSachOrder();
                ds = ds.Where(x => x.MaDonHang == newO.MaDonHang).ToList();
                if (ds.Count > 0)
                {
                    if(ToolService.ConverDateToInt(newO.NgayDonHang) != ToolService.ConverDateToInt(ds[0].NgayDonHang))
                    {
                        return false;
                    }
                }    
            }
            else
            {
                if(ToolService.ConverDateToInt(newO.NgayDonHang) != ToolService.ConverDateToInt(oldO.NgayDonHang))
                {
                    return false;
                }    
            }
            var temp = order.DanhSachOrder();
            temp = temp.Where(x => x.MaDonHang == oldO.MaDonHang).ToList();
            foreach(var item in temp)
            {
                item.MaDonHang = newO.MaDonHang;
                item.NgayDonHang = newO.NgayDonHang;
                order.SuaOrder(item);
            }    
            return true;
        }

        public bool SuaMotOrder(Order oldO, Order newO)
        {
            if(oldO.SanPham == newO.SanPham)
            {
                var p = productService.ProductById(newO.SanPham);
                if(p.SoLuong - (newO.SoLuong - oldO.SoLuong) < 0)
                {
                    return false;
                }
                else
                {
                    p.SoLuong = p.SoLuong - (newO.SoLuong - oldO.SoLuong);
                    productService.SuaProduct(p);
                    order.SuaOrder(newO);
                    return true;
                }
            }
            else
            {
                var p = productService.ProductById(newO.SanPham);
                if( p.SoLuong - newO.SoLuong < 0)
                {
                    return false;
                }
                else
                {
                    p = productService.ProductById(oldO.SanPham);
                    p.SoLuong += oldO.SoLuong;
                    productService.SuaProduct(p);
                    p = productService.ProductById(newO.SanPham);
                    p.SoLuong -= newO.SoLuong;
                    productService.SuaProduct(p);
                    order.SuaOrder(newO);
                    return true;
                }
            }
        }
        public int TongSoDonHangTuan()
        {
            DateTime date = DateTime.Now;
            DayOfWeek day = date.DayOfWeek;
            int days = day - DayOfWeek.Monday;
            DateTime monday = date.AddDays(-days);
            DateTime sunday = monday.AddDays(6);

            var ds = order.DanhSachOrder();
            return ds.Where(item => (ToolService.ConverDateToInt(item.NgayDonHang) >= ToolService.ConverDateToInt(monday)) && (ToolService.ConverDateToInt(item.NgayDonHang) <= ToolService.ConverDateToInt(sunday)) ).Count();
            
        }
    }
}
