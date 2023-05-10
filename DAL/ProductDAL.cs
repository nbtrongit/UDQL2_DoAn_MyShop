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
        private MyShopContext db = null;
        public ProductDAL() 
        { 
            db = new MyShopContext();
        }
        public List<Product> DanhSachProduct()
        {
            return db.Products.ToList();
        }
        public void ThemProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
