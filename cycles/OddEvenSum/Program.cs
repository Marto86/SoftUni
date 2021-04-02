﻿using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int oddSum = 0; 
            int evenSum = 0;

            for (int i = 1; i <= count; i++)
            {
                int currsum = int.Parse(Console.ReadLine());
                if (i %2 == 0 )
                {
                    evenSum += currsum;
                }
                else
                {
                    oddSum += currsum;
                }
                
            }
                if (evenSum == oddSum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {evenSum}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(oddSum-evenSum)}");
                }
        }

    }
}
