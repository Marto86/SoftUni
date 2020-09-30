using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();


            int rows = dimensions[0];
            int cols = dimensions[1];


            int [ , ] matrix = new int[cols,rows];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colread = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = colread[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum = sum + matrix[row,col];
                }
                Console.WriteLine(sum);
            }

            
        }
    }
}
