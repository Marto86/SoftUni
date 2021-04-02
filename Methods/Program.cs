using Microsoft.VisualBasic;
using System;
using System.Data.Common;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallestNumber = 0;

            if (numbers[0] <= numbers[1] && numbers[0] <= numbers[2])
            {
                smallestNumber = numbers[0];
            }
            else if (numbers[1] <= numbers[0] && numbers[1] <= numbers[2])
            {
                smallestNumber = numbers[1];

            }
            else
            {
                smallestNumber = numbers[2];
            }

            Console.WriteLine(smallestNumber);
        }
        

            
        








    }
}
