using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentsGrade = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());



                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade[name] = new List<double>();

                    studentsGrade[name].Add(grade);

                }
                else
                {
                    studentsGrade[name].Add(grade);
                }





            }


            var orderStudents = studentsGrade.AsEnumerable().OrderByDescending(x => x.Value.Average());

            foreach (var item in orderStudents)
            {
                double currentGrade = item.Value.Average();

                if (currentGrade >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {currentGrade:F2}");
                }



            }
        }
    }
}
