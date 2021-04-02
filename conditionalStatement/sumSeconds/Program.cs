using System;

namespace sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totaltime = firsTime + secondTime + thirdTime;
            int minutes = totaltime / 60;
            int seconds = totaltime % 60;

            if (seconds < 10 )
            {
                Console.WriteLine($"{ minutes}:0{ seconds}");
            }
            else
            {
                Console.WriteLine($"{ minutes}:{seconds}");
            }
        }

    }
}
