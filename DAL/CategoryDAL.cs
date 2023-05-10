using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        public List<Category> DanhSachCategory()
        {
            var db = new MyShopContext();
            return db.Categories.ToList();
        }

        public void ThemCategory(Category category)
        {
            var db = new MyShopContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void XoaCategory()
        {
            var db = new MyShopContext();
            db.Categories.RemoveRange(db.Categories);
            db.SaveChanges();
        }
    }
}
