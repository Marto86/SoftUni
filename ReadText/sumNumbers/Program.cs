using System;

namespace sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            int total = 0;

            while (input != "Stop")
            {
                total = int.Parse(input);
                input = Console.ReadLine();
                sum += total;

            }
            Console.WriteLine(sum);
        }
    }
}
