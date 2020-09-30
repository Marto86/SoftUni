using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var toss = int.Parse(Console.ReadLine());

            Queue<string> que = new Queue<string>(names);

            var currentIndex = 1;

            while (que.Count > 1 )
            {
                var currName = que.Dequeue();

                if (currentIndex == toss)
                {
                    Console.WriteLine($"Removed {currName}");
                    currentIndex = 0;
                }
                else
                {
                    que.Enqueue(currName);
                }

                currentIndex++;

            }

            Console.WriteLine($"Last is {que.Dequeue()}");

        }
    }
}
