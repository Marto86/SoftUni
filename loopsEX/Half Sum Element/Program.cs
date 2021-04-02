using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentMax = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > currentMax)
                {
                    totalSum = totalSum + currentMax;
                    currentMax = num;
                }
                else
                {
                    totalSum = totalSum + num;
                }
            }
            if (currentMax == totalSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", totalSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(totalSum - currentMax));
            }
        }
    }
}
