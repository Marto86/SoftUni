using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoints = int.Parse(Console.ReadLine());
            int count = 0;

            while (startPoints > 0)
            {
                string sector = Console.ReadLine();
               
                count++;

                if (sector == "number section")
                {
                    int pointsfromsector = int.Parse(Console.ReadLine());
                    startPoints -= pointsfromsector;
                }
                else if (sector == "double ring")
                {
                    int pointsfromsector = int.Parse(Console.ReadLine());
                    startPoints = startPoints - (pointsfromsector * 2);
                }
                else if (sector == "triple ring")
                {
                    int pointsfromsector = int.Parse(Console.ReadLine());
                    startPoints = startPoints - (pointsfromsector * 3);
                }
                else if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {count} moves!");

                    break;
                }
                if (startPoints < 0 )
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startPoints)}.");
                    break;
                }
                
            }

            if (startPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {count} moves!");
            }
        }
    }
}
