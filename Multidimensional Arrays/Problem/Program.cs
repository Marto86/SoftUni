using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Channels;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];


            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{

            //    Console.WriteLine("New row");
            //    for (int j = 0; j < matrix.GetLength(1) ;j++)
            //    {
            //        Console.WriteLine("New Col");
            //    }
            //}

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    total++;
                    Console.Write(total);
                }
            }
        }
    }
}
