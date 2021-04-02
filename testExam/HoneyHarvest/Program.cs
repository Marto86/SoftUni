using System;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double honey = 0;

            if (season == "Spring")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        honey = flowerCount * 10;
                         break;
                    case "Daisy":
                        honey = (flowerCount * 12) * 1.1;
                        
                        break;
                    case "Lavender":
                        honey = flowerCount * 12;
                        break;
                    case "Mint":
                        honey = (flowerCount * 10)* 1.1;
                        break;
                }

            }
            if (season == "Summer")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        honey = (flowerCount * 8)*1.1;
                        break;
                    case "Daisy":
                        honey = (flowerCount * 8) * 1.1;

                        break;
                    case "Lavender":
                        honey = (flowerCount * 8)*1.1;
                        break;
                    case "Mint":
                        honey = (flowerCount * 12) * 1.1;
                        break;
                }

            }
            if (season == "Autumn")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        honey = (flowerCount * 12) * 0.95;
                        break;
                    case "Daisy":
                        honey = (flowerCount * 6) * 0.95;

                        break;
                    case "Lavender":
                        honey = (flowerCount * 6) * 0.95;
                        break;
                    case "Mint":
                        honey = (flowerCount * 6) * 0.95;
                        break;
                }

            }



            Console.Write($"Total honey harvested: {honey:f2}");




        }
    }
}
