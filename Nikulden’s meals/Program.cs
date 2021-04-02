using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikulden_s_meals
{
    class Program
    {
        static void Main()
        {
            string comand;
             var mealsInfo = new Dictionary<String, List<string>>();
            int count = 0;

            while ((comand = Console.ReadLine()) != "Stop")
            {
                 List<string> comandSplit = comand.Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();

                string action = comandSplit[0];
                string guest = comandSplit[1];
                string meal = comandSplit[2];


                if (action == "Like")
                {
                    if (!mealsInfo.ContainsKey(guest))
                    {
                        mealsInfo.Add(guest, new List<string>() { meal });
                    }
                    else if (!mealsInfo[guest].Contains(meal))
                    {
                        mealsInfo[guest].Add(meal);
                    }
                }
                else if (action == "Unlike")
                {
                    if (!mealsInfo.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!mealsInfo[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        mealsInfo[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                          count++;
                    }
                }
            }

            foreach (var kvp in mealsInfo.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {count}");




        }
    }
}
