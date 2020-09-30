using System;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main()
        {
            var matrix = new int[10,20];

            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                for (int col = 0; col <matrix.GetLength(1); col++)
                {
                    matrix[row, col] = row + col;
                }

               
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();

            }
        }
    }
}
