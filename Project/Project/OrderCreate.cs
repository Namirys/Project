using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class OrderCreate : IOrderCreate
    {
        public List<Sushi> sushiOrder = new List<Sushi>();

        public void AddSushiInOrder(Sushi sushi)
        {
            float amountOfSushi = 0.0f;  
                do
                {
                    Console.WriteLine($"\nСколько {sushi.Name} вы хотите добавить?" +
                        $"\n Кол-во + «ENTER»." +
                        $"\n«ESCAPE» Если ничего не хотите добавить ");

                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                   amountOfSushi = Convert.ToSingle(Console.ReadLine());
                   break;
                }
                while (true);            

            sushi.Piece = Convert.ToInt32(sushi.Piece * amountOfSushi);
            sushi.Cost = sushi.Cost * amountOfSushi;            
            sushiOrder.Add(sushi);            
            var tempSushi = sushiOrder.SingleOrDefault(item => item.Id == sushi.Id);            
        }        
        public void GetSushisInOrder()
        {            
            foreach (var item in sushiOrder)
            {
                Console.WriteLine("{0} {1} \tЦена{2: 0.00}р.\tПорция-{3}Шт", item.Id, item.Name, item.Cost, item.Piece);
            }
            return;            
        }
        public void UpdateSushiInOrder(int id, SushiBase sushis)
        {            
           var sushi = sushiOrder.SingleOrDefault(item => item.Id == id); 
           Sushi baseSushi = sushis.GetSushiById(sushi.Id);
           Sushi tempSushi = new Sushi(baseSushi.Name,baseSushi.Cost, baseSushi.Piece);
           tempSushi.Id = sushi.Id;
           AddSushiInOrder(tempSushi);
            
        }
    }
}
