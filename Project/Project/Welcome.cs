using System;

namespace Project
{
    class Welcome
    {
        public static void WelcomeMassage()
        {
            int time = DateTime.Now.Hour;
            bool isTrueTime = true;

            switch (isTrueTime)
            {
                case true when time >= 6 && time < 12:
                    Console.WriteLine("Доброе утро");
                    break;
                case true when time >= 12 && time < 18:
                    Console.WriteLine("Добрый день");
                    break;
                case true when time >= 18 && time < 24:
                    Console.WriteLine("Добрый вечер!");
                    break;
                default:
                    Console.WriteLine("Доброй ночи");
                    break;
            }
        }
        public static void AllSushi(SushiBase sushis)
        {
            Console.WriteLine($"Вот наше меню:");
            sushis.GetSushis();
        }
    }
}
