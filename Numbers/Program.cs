using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> greatnumbers = new List<int>();

            double average = numbers.Average();
            

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    greatnumbers.Add(numbers[i]);
                }
            }
            if (greatnumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            greatnumbers.Sort();
            greatnumbers.Reverse();
            for (int i = 0; i < greatnumbers.Count; i++)
            {
                Console.Write($"{greatnumbers[i]} ");

                if (i == 4)
                {
                    break;
                }
            }

          
           
        }
    }
}
