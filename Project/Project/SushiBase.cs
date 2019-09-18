using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class SushiBase : ISushiBase
    {
        public static List<Sushi> sushis = new List<Sushi>();
        private static int _idCounter = 1;

        public void CreateSushi(Sushi sushi)
        {
            sushi.Id = _idCounter;
            _idCounter++;
            sushis.Add(sushi);
        }        
        public Sushi GetSushiById(int id)
        {           
                Sushi sushi = sushis.SingleOrDefault(item => item.Id == id);                
                return (Sushi)sushi;            
        }
        public void GetSushis()
        {
            foreach (var item in sushis)
            {                
               Console.WriteLine("{0} {1}   Цена {2: 0.00}р. Порция-{3}Шт.", item.Id, item.Name, item.Cost, item.Piece);
            }
        }
        public void UpdateSushi(Sushi sushi)
        {
               var exiStsushi = sushis.SingleOrDefault(item => item.Id == sushi.Id);               

                exiStsushi.Name = sushi.Name;                
                exiStsushi.Piece = sushi.Piece;                
                exiStsushi.Cost = sushi.Cost;            
        }
    }
}
