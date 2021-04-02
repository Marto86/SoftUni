using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> material = new Dictionary<string, long>();
            string product;
            while ((product = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!material.ContainsKey(product))
                {
                    material[product] += quantity;
                }
            }
            foreach (var kvp in material)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
