using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            while (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");







        }

    }
}
