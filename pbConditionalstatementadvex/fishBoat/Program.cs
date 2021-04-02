using System;

namespace fishBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //int budget = int.Parse(Console.ReadLine());
            //string season = Console.ReadLine();
            //int fishman = int.Parse(Console.ReadLine());
            //double price = 0;

            double budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double sum = 0;
            double even = 1;
            if (count % 2 == 0)
            {
                even = .95;
            }
            switch (season)
            {
                case "Spring": sum = 3000 * even; 
                    break;
                case "Summer": sum = 4200 * even; 
                    break;
                case "Autumn": sum = 4200; 
                    break;
                case "Winter": sum = 2600 * even;
                    break;
                default: 
                    break;

            }
            if (count >= 12)
            {
                sum = sum * .75;
            }
            else if (count >= 7)
            {
                sum = sum * .85;
            }
            else
            {
                sum = sum * .9;
            }
            if (budget >= sum)
            {
                Console.WriteLine($"Yes! You have {(budget - sum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(sum - budget):F2} leva.");
            }




        }
    }
}
