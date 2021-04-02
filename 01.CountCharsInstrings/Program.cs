using System;
using System.Collections.Generic;

namespace _01.CountCharsInstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> material = new Dictionary<string, long>();

            string product;
            while ((product = Console.ReadLine()) != "stop")
            {
                int quantiy = int.Parse(Console.ReadLine());
                if (!material.ContainsKey(product))
                {
                    material[product] = 0;
                }
                material[product] += quantiy;
            }

            foreach (var kvp in material)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
