using System;

namespace newHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowertype = Console.ReadLine();
            double flowercount = int.Parse(Console.ReadLine());
            double budget = int.Parse(Console.ReadLine());
            double price = 0;


            switch (flowertype)
            {
                case "Roses":

                price = flowercount * 5;
                    if (flowercount > 80)
                    {
                        price = flowercount * (5 * 0.9);
                    }
                    break;
                case "Dahlias":
                    price = flowercount * 3.8;
                    if (flowercount > 90)
                    {
                        price = flowercount * (3.8 * 0.85);
                    }
                    break;
                case "Tulips":
                    price = flowercount * 2.8;
                    if (flowercount > 80)
                    {
                        price = flowercount * (2.8 * 0.85);
                    }
                    break;
                case "Narcissus":
                    price = flowercount * 3;
                    if (flowercount < 120)
                    {
                        price = flowercount * (2.8 * 1.15);
                    }
                    break;
                case "Gladiolus":
                    price = flowercount * 2.5;
                    if (flowercount < 80)
                    {
                        price = flowercount * (2.5 * 1.2);
                    }
                    break;



                    
                   
            }
            if (budget >= price)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", flowercount, flowertype, budget - price);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", price - budget);
            }



        }
    }
}
