using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> information = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n ; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!information.ContainsKey(continent))
                {
                    information.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!information[continent].ContainsKey(country))
                {
                    information[continent].Add(country, new List<string>());
                }

                
                information[continent][country].Add(city);

            }
            foreach (var continent in information)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }


            }
        }
    }
}
