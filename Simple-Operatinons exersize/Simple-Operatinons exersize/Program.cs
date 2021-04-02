using System;

namespace Simple_Operatinons_exersize
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.795498;
            Console.WriteLine($"{bgn:F2}");


        }
    }
}
