using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        public List<Order> DanhSachOrder()
        {
            var db = new MyShopContext();
            return db.Orders.ToList();
        }
    }
}
