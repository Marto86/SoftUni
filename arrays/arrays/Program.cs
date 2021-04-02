using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[ ] { "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };
            
            int dayAsNumber = int.Parse(Console.ReadLine());
            if (dayAsNumber < 1|| dayAsNumber > 7 )
            {
                Console.WriteLine("Invalid day!");

            }
            else
            {
            Console.WriteLine( days[dayAsNumber - 1]);
            }
        }
    }
}
