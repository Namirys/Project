using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.directory.Create();
            Log.Logs("Статус:Запущен");

            SushiBase sushiBase = new SushiBase();
            sushiBase = Menu.MenuCreate(sushiBase);
            Log.Logs("Меню создано");

            OrdersBase orders = new OrdersBase();
            
            Log.Logs("Новый заказ статус: Начат");
            orders.AddOrder(CreateNewOrder(sushiBase));
            Log.Logs("Новый заказ стаутус: Закончен");  
            Log.Logs("Заказ завершен");
            Console.Read();
        }
        static Order CreateNewOrder(SushiBase sushiBase)
        {
            OrderCreat newOrder = new OrderCreat();            
            newOrder.CreateOrder(sushiBase);
            Log.Logs("Новый заказ: Закончен");
            Order order = newOrder.PersonInfo(newOrder.orderCreate);
            Log.Logs("Ввод данных: Закончен");            
            Log.Logs("Заказ скомплектован");    
            return order;
        }
    }
}
