using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static ATP2_AssignmentEntities context;
        static OrderRepo()
        {
            context = new ATP2_AssignmentEntities();
        }
        public static List<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }
        public static int AddOrder(Order o)
        {
            o.date = DateTime.Now;
            context.Orders.Add(o);
            context.SaveChanges();
            return o.id;
        }

        public static void AddProductOrder(cart p)
        {
            context.carts.Add(p);
            context.SaveChanges();
        }
        public static List<cart> GetOrder(int id)
        {
            return context.carts.Where(e => e.order_id == id).ToList();
        }

        public static Order GetOrderInfo(int id)
        {
            return context.Orders.FirstOrDefault(e => e.id == id);
        }
    }
}
