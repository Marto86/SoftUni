using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studens = new Dictionary<string,List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = decimal.Parse(tokens[1]);

                if (!studens.ContainsKey(name))
                {
                    studens[name]= new List<decimal>();
                    studens[name].Add(grade);
                }
                else if (studens.ContainsKey(name))
                {
                    studens[name].Add(grade);
                }
                
                
                
            }

            foreach (var pair in studens)
            {

                var name = pair.Key;
                var grades = pair.Value;
                var average = grades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in  grades)
                {
                    Console.Write($"{grade:f2} ");
                    
                } 
                Console.WriteLine($"(avg: {average:F2})");
                
            }
        }
    }
}
