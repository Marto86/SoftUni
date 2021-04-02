using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int employerPower1 = int.Parse(Console.ReadLine());
            int employerPower2 = int.Parse(Console.ReadLine());
            int employerPower3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int peoplePerHour = employerPower1 + employerPower2 + employerPower3;
            int hours = 0;
            while (students > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                students = students - peoplePerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");


        }
    }
}
