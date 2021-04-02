using System;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            var destinationresult = string.Empty;
            var holidayresult = string.Empty;

         
    

            if (budget <=100)
            {
                destinationresult = "Bulgaria";
                if (season == "summer")
                {   
                    holidayresult = "Camp" ;
                    price = budget * 0.3;
                }
                else
                {
                    holidayresult = "Hotel";
                    price = budget * 0.7;
                }


            }
            else if (budget <= 1000)
            {
                destinationresult = "Balkans";
                if (season == "summer")
                {
                    holidayresult = "Camp";
                    price = budget * 0.4;
                }
                else
                {
                    holidayresult = "Hotel";
                    price = budget * 0.8;
                }

            }
            else
            {
                holidayresult = "Hotel";
                destinationresult = "Europe";
                price = budget * 0.9;
                    
            }

            Console.WriteLine("Somewhere in {0}", destinationresult);
            Console.WriteLine($"{holidayresult} - {price:F2}");

        }
            




        
    }
}
