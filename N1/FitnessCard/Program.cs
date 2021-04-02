using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double totalPrice = 0;

            if (sex == 'm')
            {
                switch (sport)
                {
                    case "Gym":
                        totalPrice += 42;

                        break;
                    case "Boxing":

                        totalPrice += 41;
                        break;
                    case "Yoga":

                        totalPrice += 45;
                        break;
                    case "Zumba":

                        totalPrice += 34;
                        break;
                    case "Dances":

                        totalPrice += 51;
                        break;
                    case "Pilates":

                        totalPrice += 39;
                        break;
                }
            }
            if (sex == 'f')
            {
                switch (sport)
                {
                    case "Gym":
                        totalPrice += 35;

                        break;
                    case "Boxing":

                        totalPrice += 37;
                        break;
                    case "Yoga":

                        totalPrice += 42;
                        break;
                    case "Zumba":

                        totalPrice += 31;
                        break;
                    case "Dances":

                        totalPrice += 53;
                        break;
                    case "Pilates":

                        totalPrice += 37;
                        break;
                }







            }
            if (age <= 19)
            {
                totalPrice = totalPrice * 0.80;
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                totalPrice = totalPrice - budget;
                Console.WriteLine($"You don't have enough money! You need ${totalPrice:F2} more.");
            }
        }


    }
}

