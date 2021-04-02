using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string trips = Console.ReadLine();

            string patern = @"([\=\/])(?<dest>[A-Z][a-zA-Z]{2,})\1";

            var match = Regex.Matches(trips, patern);


            List<string> Matches = new List<string>();
            int points = 0;

            foreach (Match city in match)
            {
                if (city.Success)
                {
                    string mach = city.Groups["dest"].Value;

                    int Length = mach.Length;

                    points = points + Length;

                    Matches.Add(mach);
                }

            }

            Console.WriteLine($"Destinations: {string.Join(", ", Matches)}");
            
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
