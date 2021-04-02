using System;

namespace CleverLyli
{
    class Program
    {
        static void Main(string[] args)
        {
            int YearLili = int.Parse(Console.ReadLine());
            double priceWashing = double.Parse(Console.ReadLine());
            double priceGame = double.Parse(Console.ReadLine());

            double total = 0;
            double money = 0;

            for (int i = 1; i <= YearLili; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    total += money;
                    total--;
                }
                else
                {
                    total += priceGame;
                }
            }
            if (total >= priceWashing)
            {
                Console.WriteLine($"Yes! {total - priceWashing:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashing - total:f2}");
            }
        }
    }
}
