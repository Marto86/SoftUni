using System;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {





            string month = Console.ReadLine();
            int nightsNumber = int.Parse(Console.ReadLine());


            decimal priceStayStudio = 0.00M;
            decimal priceStayApartment = 0.00M;

            if (month == "May" || month == "October")
            {
                priceStayApartment = nightsNumber * 65.00M;
                priceStayStudio = nightsNumber * 50.00M;
                if (nightsNumber > 7 && nightsNumber <= 14)
                {
                    priceStayStudio = nightsNumber * (50.00M * 0.95M);
                }
                else if (nightsNumber > 14)
                {
                    priceStayStudio = nightsNumber * (50.00M * 0.70M);
                }
                if (nightsNumber > 14)
                {
                    priceStayApartment = nightsNumber * (65.00M * 0.90M);
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStayApartment = nightsNumber * 68.70M;
                priceStayStudio = nightsNumber * 75.20M;

                if (nightsNumber > 14)
                {
                    priceStayStudio = nightsNumber * (75.20M * 0.80M);
                    priceStayApartment = nightsNumber * (68.70M * 0.90M);
                }
            }

            else if (month == "July" || month == "August")
            {
                priceStayStudio = nightsNumber * 76.00M;
                priceStayApartment = nightsNumber * 77.00M;
                if (nightsNumber > 14)
                {
                    priceStayApartment = nightsNumber * (77.00M * 0.90M);
                }

            }

            Console.WriteLine($"Apartment: {decimal.Round(priceStayApartment, 2):f2} lv.");
            Console.WriteLine($"Studio: {decimal.Round(priceStayStudio, 2):f2} lv.");
        }Console
 