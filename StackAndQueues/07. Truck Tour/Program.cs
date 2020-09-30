using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 0;
            Queue<int[]>  pumps = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] currPumps = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                pumps.Enqueue(currPumps);
               
            }

            while (true)
            {
               
                var fuelAmount = 0;
                bool foundpoint = true;

                foreach (var pump in pumps)
                {
                    fuelAmount += pump[0];
                    if (fuelAmount < pump[1])
                    {
                        foundpoint = false;
                        break;
                    }

                    fuelAmount -= pump[1];
                }

                if (foundpoint)
                {
                    break;
                }

                counter++;
                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(counter);
        }
    }
}
