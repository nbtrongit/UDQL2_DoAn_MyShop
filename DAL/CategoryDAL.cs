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
        private MyShopContext db = null;
        public CategoryDAL()
        {
            db = new MyShopContext();
        }
        public List<Category> DanhSachCategory()
        {
            return db.Categories.ToList();
        }

        public void ThemCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
        public void Xoa1Category(Category del)
        {
            db.Categories.Remove(del);
            db.SaveChanges();
        }
        public void XoaCategory()
        {
            db.Categories.RemoveRange(db.Categories);
            db.SaveChanges();
        }
        public void SuaCategory(Category up, string newCategory) 
        {
            var item = db.Categories.FirstOrDefault(c => c.Id == up.Id);
            item.Ten = newCategory;
            db.SaveChanges();
        }
    }
}
