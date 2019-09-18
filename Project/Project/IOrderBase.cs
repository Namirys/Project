using System.Collections.Generic;

namespace Project
{
    interface IOrderBase
    {
        void AddOrder(Order order);

        Order GetOrder(int id);

        Order UpdateOrder(Order order);

        List<Order> GetOrders();        
    }
}
