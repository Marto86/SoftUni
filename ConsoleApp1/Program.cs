using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(10000);
            //string output = " text";
            Stopwatch watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < 1000; i++)
            {
               // output = output + "Softuni";
                sb.Append("SoftUni");
                
            }
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
