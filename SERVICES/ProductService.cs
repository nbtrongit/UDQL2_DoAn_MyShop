using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
