using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetAllOrders()
        {
            var orders = OrderRepo.GetAllOrders();
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }
        public static int AddOrder(OrderModel o)
        {
            var order = AutoMapper.Mapper.Map<OrderModel, Order>(o);
            return OrderRepo.AddOrder(order);
        }

        public static void AddProductOrder(CartModel item)
        {
            var productOrder = AutoMapper.Mapper.Map<CartModel, cart>(item);
            OrderRepo.AddProductOrder(productOrder);
        }
        public static List<CartModel> GetOrder(int id)
        {
            var productOrders = OrderRepo.GetOrder(id);
            return AutoMapper.Mapper.Map<List<cart>, List<CartModel>>(productOrders);
        }

        public static OrderModel GetOrderInfo(int id)
        {
            var order = OrderRepo.GetOrderInfo(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(order);
        }
    }
}
