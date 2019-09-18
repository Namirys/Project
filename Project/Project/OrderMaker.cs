using System;
using System.Timers;

namespace Project
{
    class OrderCreat
    {   
        public OrderCreate orderCreate = new OrderCreate();
        public OrderCreate CreateOrder(SushiBase sushis)
        {
            Welcome.WelcomeMassage();
            Welcome.AllSushi(sushis);
            do
            {
                do
                {
                    try
                    {
                        AddSushiOrNothing(sushis);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nНеобходимо ввести номер вида суши");
                        Log.Logs($"Не верный Номер {ex.Message}\n{ex.StackTrace}");
                        continue;
                    }
                    orderCreate.GetSushisInOrder();
                    Console.WriteLine("\nЦена заказа {0: 0.00}", SumCounter(orderCreate));
                    if (AnythingElse(sushis))
                    {
                        continue;
                    }
                    break;
                }
                while (true);
                Console.WriteLine("\nВы хотите завершить заказ? " +
                    "\n Нажмите «ENTER», если да, или еще что-нибудь, если нет");

                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    orderCreate.GetSushisInOrder();
                    Console.WriteLine("\nЦена заказа {0: 0.00}", SumCounter(orderCreate));
                    break;
                }
            }
            while (true);

            return orderCreate;
        }
        public Order PersonInfo(OrderCreate orderBase)
        {
            string name = string.Empty,
            address = string.Empty;
            long phone = 0;

            do
            { 
              Console.WriteLine("\nВведите имя");
              name = Console.ReadLine();
                Log.Logs($"Имя-> {name}");
                do
                {
                    try
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        phone = Convert.ToInt32(Console.ReadLine());
                        Log.Logs($"Номер телефона->{phone}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("В номере не должно быть букв");
                        Log.Logs($"Не верный номер\n{ex.Message}\n{ex.StackTrace}");
                        continue;
                    }
                    break;
                }
                while (true);
                
                Console.WriteLine("\nВведите ваш адрес:");
                address = Console.ReadLine();
                Log.Logs($"Адрес-> {address}");

                Console.WriteLine($"\nЭто ваш заказ:"
                                  + $"\nВаше имя: {name}"
                                  + $"\nВаш номер: {phone}"
                                  + $"\nВаш адрес: {address}\n"
                                  + $"\nСуши в вашем заказе:");
                Extantions.SushiExtention(orderBase.sushiOrder);
                Console.WriteLine("\nНажмите «ENTER», если все правильно или что-нибудь еще, если нет");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);

            float sum = SumCounter(orderBase);
            Order order = new Order(name, phone, address, orderBase.sushiOrder, sum);
            order.dayOfWeek = (TheDayOfWeek)DateTime.Now.DayOfWeek;

            return order;
        }
        public float SumCounter(OrderCreate orderBase)
        {
            float sum = 0.0f;

            foreach (var item in orderBase.sushiOrder)
            {
                sum += item.Cost;
            }
            return sum;
        }
        public void AddSushiOrNothing(SushiBase sushis)
        {
            Console.WriteLine("\nКакие суши вы хотите заказать? " + " " +
                "\nВведите номер +  'ENTER', чтобы добавить суши " +
                "\nНажмите 'ESCAPE', если вы ничего не добавите.");

            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                int idSushiToOrder = Convert.ToInt32(Console.ReadLine());
                Sushi sushi = sushis.GetSushiById(idSushiToOrder);
                Sushi tempSushi = new Sushi(sushi.Name, sushi.Cost, sushi.Piece);
                tempSushi.Id = idSushiToOrder;
                orderCreate.AddSushiInOrder(tempSushi);
            }
        }
        public bool AnythingElse(SushiBase sushis)
        {
            Console.WriteLine("\nЧто-нибудь еще? " +
                "\n Нажмите ESCAPE, если нет " +                
                "\nНажмите что-нибудь еще, если хотите добавить больше суши в заказ.");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                return false;
            }
            else
            {
                Console.Clear();
                Welcome.AllSushi(sushis);
                return true;
            }
        }        
    }
}
