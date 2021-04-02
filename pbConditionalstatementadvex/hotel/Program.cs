using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {


            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal priceap = 0.00M;
            decimal pricestudio = 0.00M;

            if (month == "May" || month == "October")
            {
                priceap = 65.00M;
                pricestudio = 50.00M;
                if (nights > 7 && nights <= 14)
                {
                    pricestudio = (pricestudio * 0.95M) * nights;
                    priceap = priceap * nights;
                }
                else if (nights > 14)
                {
                    pricestudio = (pricestudio * 0.700M) * nights;
                    priceap = (priceap * 0.900M) * nights;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceap = 68.700M;
                pricestudio = 75.200M;
                if (nights > 7 && nights <= 14)
                {
                    pricestudio = pricestudio * nights;
                    priceap = priceap * nights;
                }
                else
                {
                    pricestudio = (pricestudio * 0.800M) * nights;
                    priceap = (priceap * 0.900M) * nights;
                }

            }
            else if (month == "July" || month == "August")
            {
                priceap = 77;
                pricestudio = 76;
                if (nights > 14)
                {
                    pricestudio = pricestudio * nights;
                    priceap = (priceap * 0.900M) * nights;

                }


            }


            Console.WriteLine($"Apartment: {decimal.Round(priceap, 2):f2} lv.");
            Console.WriteLine($"Studio: {decimal.Round(pricestudio, 2):f2} lv.");

        }
    }
}

