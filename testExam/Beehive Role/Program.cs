using System;

namespace Beehive_Role
{
    class Program
    {
        static void Main(string[] args)
        {
            int intelekt = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (intelekt >= 80 && power >= 80 && sex == "female" )
            {
                Console.WriteLine("Queen Bee");
            }
            else if (intelekt >= 80  )
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (intelekt >= 60 )
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (power>=80 && sex == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (power>= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
           


        }
    }
}
