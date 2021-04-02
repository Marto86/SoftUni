using System;

namespace projectCraetion
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double project = double.Parse(Console.ReadLine());

            double projectTime = project * 3;

            Console.WriteLine($"The architect {name} will need {projectTime} hours to complete {project} project/s.");

        }
            
    }
}
