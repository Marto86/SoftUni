using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesValue);
            var racks = 1;
            var sum = 0;
           
            while (clothes.Count > 0)
            {

                sum = sum + clothes.Peek();
                if (sum <= rackCapacity)
                {
                    clothes.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
