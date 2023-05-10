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
        public List<User> DanhSachUser()
        {
            var db = new MyShopContext();
            return db.Users.ToList();
        }
    }
}
