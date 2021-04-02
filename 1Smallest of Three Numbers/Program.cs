using System;
using System.Linq;

namespace _1Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            
          
        }
        static int smallNumber ()
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
            return smallestNumber;

        }
        

    }






}
