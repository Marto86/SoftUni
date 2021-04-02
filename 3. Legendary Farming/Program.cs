using System;
using System.Collections.Generic;
using System.Linq;

namespace legendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dragonwrath = false;
            bool shadowmourne = false;

            bool valanyr = false;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            resources.Add("motes", 0);
            resources.Add("fragments", 0);
            resources.Add("shards", 0);

            while (true)
            {
                string inputRaw = Console.ReadLine().ToLower();
                string[] input = inputRaw.Split().ToArray();

                for (int i = 1; i <= input.Length; i += 2)
                {
                    if (resources.ContainsKey(input[i]) == false)
                    {
                        resources.Add(input[i], 0);
                    }
                    resources[input[i]] += int.Parse(input[i - 1]);
                    if (resources[input[i]] > 250)
                        break;
                }
                if (resources["motes"] >= 250)
                {
                    dragonwrath = true;
                    resources["motes"] -= 250;
                    break;
                }
                else if (resources["fragments"] >= 250)
                {
                    valanyr = true;
                    resources["fragments"] -= 250;
                    break;
                }
                else if (resources["shards"] >= 250)
                {
                    shadowmourne = true;
                    resources["shards"] -= 250;
                    break;
                }
            }
            var result = resources
                .Where(x => x.Key == "motes" || x.Key == "fragments" || x.Key == "shards")
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
            var result2 = resources
                .Where(x => x.Key != "motes" && x.Key != "fragments" && x.Key != "shards")
                .OrderBy(x => x.Key)
                .ToArray();

            if (dragonwrath)
            {
                Console.WriteLine("Dragonwrath obtained!");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in result2)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (valanyr)
            {
                Console.WriteLine("Valanyr obtained!");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in result2)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (shadowmourne)
            {
                Console.WriteLine("Shadowmourne obtained!");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in result2)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}