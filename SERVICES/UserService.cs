using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using DAL;
using static System.Net.Mime.MediaTypeNames;

namespace SERVICES
{
    public class UserService
    {
        private UserDAL dal = null;
        public UserService()
        {
            dal = new UserDAL();
        }
        public bool KiemTraUser(string username, string password)
        {
            if (username == "" || password == "")
            {
                return false;
            }   
            
            List<User> danhsach = dal.DanhSachUser();

            foreach(var item in danhsach)
            {
                if(string.Equals(item.Username.Trim(), username, StringComparison.Ordinal) && string.Equals(item.Password.Trim(), password, StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
