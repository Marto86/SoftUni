using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
            int evenSum = 0;
            int oddSum = 0;
            int diference = 0;
            


            for (int i = 0; i < arr.Length; i++)
            {
                int currNumber = arr[i];

                if (currNumber % 2 == 0)
                {
                    evenSum = evenSum + currNumber;
                }
                else
                {
                    oddSum = oddSum + currNumber;
                }

            }
            diference = evenSum - oddSum;
            Console.WriteLine(diference);
           

            


        }
    }
}
