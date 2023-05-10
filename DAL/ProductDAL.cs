using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        public List<Product> DanhSachProduct()
        {
            var db = new MyShopContext();
            return db.Products.ToList();
        }
        public void ThemProduct(Product product)
        {
            var db = new MyShopContext();
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
