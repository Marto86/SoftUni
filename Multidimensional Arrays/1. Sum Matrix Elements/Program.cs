using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseArayFromConsloe();
            int rows = dimensions[0];
            int cols = dimensions[1];

            

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] curArr = ParseArayFromConsloe();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = curArr[col];
                }
            }

            long sum = 0;
            foreach (var Element in matrix)
            {
                sum = sum + Element;
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols); 
            Console.WriteLine(sum);
        }

        static int[] ParseArayFromConsloe() 
        {
            return Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }
    }
}
