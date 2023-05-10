using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace DAL
{
    public class UserDAL
    {
        private MyShopContext db = null;
        public UserDAL() 
        {
            db = new MyShopContext();
        }
        public List<User> DanhSachUser()
        {
            return db.Users.ToList();
        }
    }
}
