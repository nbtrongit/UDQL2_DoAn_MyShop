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
        public void ThemOrder(Order newO)
        {
            db.Orders.Add(newO);
            db.SaveChanges();
        }
        public void XoaOrder(List<Order> del)
        {
            foreach(var item in del)
            {
                db.Orders.Remove(item);
            }
            db.SaveChanges();
        }
        public void XoaMotOrder(Order del)
        {
            db.Orders.Remove(del);
            db.SaveChanges();
        }
        public void SuaOrder(Order up)
        {
            db.Orders.Update(up);
            db.SaveChanges();
        }
    }
}
