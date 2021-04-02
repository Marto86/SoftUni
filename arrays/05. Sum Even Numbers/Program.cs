using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNumber = arr[i];
                if (currNumber % 2 == 0)
                {
                    sum = sum + currNumber;
                }
            }
            Console.WriteLine(sum);
        }

    }
}
