using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var foodQuantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            Queue<int> allOrders = new Queue<int>(orders);

            var sum = 0;
            
            Console.WriteLine(allOrders.Max());
            while (allOrders.Count > 0)
            {
                var first = allOrders.Peek();
                sum = sum + first;

                if (sum <= foodQuantity)
                {
                    allOrders.Dequeue();
                }
                else
                {
                    var arr = allOrders.ToArray();
                    Console.WriteLine("Orders left: " + string.Join(" ",arr) );
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
