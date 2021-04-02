using System;

namespace timeplus15
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            m += 15;

            if (m >= 60)
            {
                m = m - 60;
                h = h + 1;
            }
            if (h >= 24)
            {
                h = 0; 
            }
            Console.WriteLine($"{h}:{m:d2}");
        }
    }
}
