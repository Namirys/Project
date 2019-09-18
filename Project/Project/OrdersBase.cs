using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class OrdersBase : IOrderBase
    {
        public static List<Order> orders = new List<Order>();
        private static int _idCounter = 1;

        public void AddOrder(Order order)
        {
            order.Id = _idCounter;
            _idCounter++;
            orders.Add(order);
        }
        public void DeleteOrder(int id)
        {
            var existOrder = orders.SingleOrDefault(item => item.Id == id); 
            orders.Remove(existOrder);
        }
        public Order GetOrder(int id)
        {
            var order = orders.SingleOrDefault(item => item.Id == id);
            return (Order)order;
        }
        public List<Order> GetOrders()
        {
            return orders.Select(item => (Order)item).ToList();
        }

        public Order UpdateOrder(Order order)
        {
            var existOrder = orders.SingleOrDefault(item => item.Id == order.Id);            
            existOrder.Name = order.Name;
            existOrder.PhoneNumber = order.PhoneNumber;
            existOrder.Address = order.Address;
            existOrder.OrderSushi = order.OrderSushi;
            existOrder.TotalSum = order.TotalSum;
            return (Order)existOrder;
        }
    }
}
