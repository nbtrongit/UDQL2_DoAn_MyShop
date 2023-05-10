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
        private MyShopContext db = null;
        public OrderDAL()
        {
            db = new MyShopContext();
        }
        public List<Order> DanhSachOrder()
        {
            return db.Orders.ToList();
        }
    }
}
