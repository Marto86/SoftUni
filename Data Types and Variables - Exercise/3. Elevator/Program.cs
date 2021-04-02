using System;
using System.Dynamic;
using System.Globalization;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = n / p;
            int restCourses = n % p;

            if (restCourses == 0 )
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses + restCourses/restCourses);
            }

            
                

        }
    }
}
