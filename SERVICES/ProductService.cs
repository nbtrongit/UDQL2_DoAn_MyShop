using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace SERVICES
{
    public class ProductService
    {
        private ProductDAL product = null;
        private OrderDAL order = null;
        public ProductService()
        {
            this.product = new ProductDAL();
            this.order = new OrderDAL();
        }
        public List<Product> DanhSachProduct()
        {
            var ds = product.DanhSachProduct();
            foreach (var item in ds)
            {
                item.Ten = item.Ten.Trim();
            }    
            return product.DanhSachProduct();
        }
        public List<Product> DanhSachProductConHang()
        {
            var ds = product.DanhSachProduct();
            foreach (var item in ds)
            {
                item.Ten = item.Ten.Trim();
            }

            return ds.Where(x => x.SoLuong > 0).ToList(); ;
        }
        public bool ThemProduct(Product newP)
        {
            product.ThemProduct(newP);
            return true;
        }
        public bool XoaProduct(Product p)
        {
            var ds = order.DanhSachOrder();
            foreach(var item in ds)
            {
                if (item.SanPham == p.Id)
                {
                    return false;
                }    
            }
            product.XoaProduct(p);
            return true;
        }
        public bool SuaProduct(Product newP)
        {
            var ds = order.DanhSachOrder();
            int count = 0;
            foreach (var item in ds)
            {
                if (item.SanPham == newP.Id)
                {
                    count += item.SoLuong;
                }
            }

            if (newP.SoLuong < count)
            {
                return false;
            }

            product.SuaProduct(newP);
            return true;
        }

        public int MaxPriceProduct()
        {
            var ds = product.DanhSachProduct();
            int max = 0;
            foreach (var item in ds)
            {
                if (item.Gia > max )
                {
                    max = (int)item.Gia;
                }
            }
            return max;
        }

        public Tuple<ObservableCollection<Product>, int> GetAll(int page, int itemsPerPage, string keyword, int min, int max, int categoryId)
        {
            var ds = product.DanhSachProduct();

            if (categoryId != 0)
            {
                var query = ds.Where(item => item.Ten.Contains(keyword) && (item.Gia >= min && item.Gia <= max) && item.LoaiSanPham == categoryId);
                var result = query
                    .Skip((page - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .ToList();
                return new Tuple<ObservableCollection<Product>, int>(new ObservableCollection<Product>(result), query.Count());
            }
            else
            {
                var query = ds.Where(item => item.Ten.Contains(keyword) && (item.Gia >= min && item.Gia <= max));
                var result = query
                    .Skip((page - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .ToList();
                return new Tuple<ObservableCollection<Product>, int>(new ObservableCollection<Product>(result), query.Count());
            }
        }

        public List<Product> GetProductByMaDonHang (string madonhang)
        {
            var orders = order.DanhSachOrder();
            var products = product.DanhSachProduct();

            foreach(var item in products)
            {
                item.SoLuong = 0;
            }

            var result = orders.Where(x => x.MaDonHang == madonhang)
                .GroupBy(x => x.SanPham)
                .Select(g => new Product
                {
                    Id = g.Key,
                    Ten = products.First(x => x.Id == g.Key).Ten,
                    Gia = products.First(x => x.Id == g.Key).Gia,
                    HinhAnh = products.First(x => x.Id == g.Key).HinhAnh,
                    SanXuat = products.First(x => x.Id == g.Key).SanXuat,
                    SoLuong = g.Sum(x => x.SoLuong)
                })
                .ToList();
            return result;
        }

        public Product ProductById(int Id)
        {
            var ds = product.DanhSachProduct();
            foreach(var item in ds)
            {
                if (item.Id == Id)
                {
                    return item!;
                }    
            }
            return null;
        }

        public int TongSoSp()
        {
            int count = 0;
            var ds = product.DanhSachProduct();
            foreach(var item in ds)
            {
                count += item.SoLuong;
            }
            return count;
        }

        public List<Product> SanPhamSapHetHang(int num, int max)
        {
            var ds = product.DanhSachProduct();
            var query = ds.Where(item => item.SoLuong <= max).Take(num).ToList();
            return query;
        }
    }
}
