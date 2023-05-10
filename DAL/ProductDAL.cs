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
        public void XoaProduct(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
        public void SuaProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
    }
}
