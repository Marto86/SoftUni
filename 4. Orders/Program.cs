using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>();
            Dictionary<string, long> productQty = new Dictionary<string, long>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productarg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = productarg[0];
                decimal price = decimal.Parse(productarg[1]);
                int quantity = int.Parse(productarg[2]);

                if (!productQty.ContainsKey(name))
                {
                    productQty[name] = 0;
                    productPrices[name] = 0m;
                }
                productQty[name] += quantity;
                productPrices[name] = price;



            }
            PrintOutput(productPrices, productQty);
        }

        private static void PrintOutput(Dictionary<string, decimal> productPrices, Dictionary<string, long> productQty)
        {
            foreach (var kvp in productPrices)
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                long quantity = productQty[name];
                decimal totalPrice = price * quantity;
                Console.WriteLine($"{name} -> {totalPrice:f2}");

            }
        }
    }
}
