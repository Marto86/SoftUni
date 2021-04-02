using System;

namespace Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {

            int startPopulation = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int endPopultaion = 0;

            for (int Year = 1; Year <= years; Year++)
            {
                startPopulation += startPopulation / 10 * 2;

                if (Year % 5 == 0)
                {
                    startPopulation -= startPopulation / 50 * 5;
                }

                endPopultaion = startPopulation / 20 * 2;
                startPopulation -= endPopultaion;
            }
            Console.WriteLine($"Beehive population: {startPopulation}");
        }
    }
}
