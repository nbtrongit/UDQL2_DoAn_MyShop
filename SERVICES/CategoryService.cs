using DAL;
using ENTITIES;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class CategoryService
    {
        private CategoryDAL category = null;

        public CategoryService()
        {
            this.category = new CategoryDAL();
        }
        public List<Category> DanhSachCategory()
        {
            return category.DanhSachCategory();
        }
        public bool ThemCategory(string newCategory)
        {
            if (newCategory == "")
            {
                return false;
            }    
            Category temp = new Category() { Ten = newCategory.Trim()};
            category.ThemCategory(temp);

            return true;
        }
        public bool Xoa1Category(Category del)
        {
            category.Xoa1Category(del);
            return true;
        }
        public bool SuaCategory(Category up, string newCategory)
        {
            if (newCategory == "")
            {
                return false;
            }    
            category.SuaCategory(up, newCategory);
            return true;
        }
    }
}
