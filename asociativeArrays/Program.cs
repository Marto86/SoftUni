using System;
using System.Collections.Generic;
using System.Linq;

namespace asociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {

                if (!dict.ContainsKey(numbers[i]))
                {
                 
                    dict.Add(numbers[i], 1);

                }
                else
                {
                    dict[numbers[i]]++;
                }


            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " ->  " + item.Value);

            }
        }
    }
}
