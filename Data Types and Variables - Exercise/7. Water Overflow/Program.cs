using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int all = 255;
            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (capacity + litres <= all)
                {
                    capacity += litres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(capacity);
        }
    }
}
