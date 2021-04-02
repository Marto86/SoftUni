using System;

namespace exampreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initaialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxStudentAtendance = 0;


             
            for (int i = 0; i < studentsCount; i++)
            {
                int studentAtendace = int.Parse(Console.ReadLine());

                double totalBonus = (double) studentAtendace  / lecturesCount * (5 + initaialBonus) ;

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxStudentAtendance = studentAtendace;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxStudentAtendance} lectures.");




        }
    }
}
