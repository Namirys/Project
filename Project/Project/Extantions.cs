using System;
using System.Collections.Generic;

namespace Project
{
    public static class Extantions
    {
        public static void SushiExtention(this List<Sushi> sushis)
        {
            float sum = 0;
            foreach (var item in sushis)
            {
                Console.WriteLine("{0} {1} \tЦена{2: 0.00}р. \tПорция-{3}Шт", item.Id, item.Name, item.Cost, item.Piece);
                sum += item.Cost;
            }
            Console.WriteLine($"Общая цена: { sum}р.");
        }

    }
}
