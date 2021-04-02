using System;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakers = int.Parse(Console.ReadLine());

            int totalCount = 0;
            double totalSum = 0;

            double priceCookies = 1.50;
            double priceCakes = 7.80;
            double priceWaffles = 2.30;

            for (int i = 1; i <= bakers; i++)
            {
                int countCookies = 0;
                int countCakes = 0;
                int countWaffles = 0;

                string name = Console.ReadLine();
                string typeMeal = Console.ReadLine();

                while (typeMeal != "Stop baking!")
                {
                    int countMeal = int.Parse(Console.ReadLine());

                    switch (typeMeal)
                    {
                        case "cookies":
                            countCookies += countMeal;
                            break;
                        case "cakes":
                            countCakes += countMeal;
                            break;
                        case "waffles":
                            countWaffles += countMeal;
                            break;
                    }

                    typeMeal = Console.ReadLine();
                }
                Console.WriteLine($"{name} baked {countCookies} cookies, {countCakes} cakes and {countWaffles} waffles.");

                totalCount += countCookies + countCakes + countWaffles;
                totalSum += (countCookies * priceCookies) + (countCakes * priceCakes) + (countWaffles * priceWaffles);
            }
            Console.WriteLine($"All bakery sold: {totalCount}");
            Console.WriteLine($"Total sum for charity: {totalSum:F2} lv.");
        }
    }
}