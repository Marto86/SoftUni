using System;

namespace areaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double side = Double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:F3}");

            }
            else if (figure == "rectangle")
            {
                double sidea = Double.Parse(Console.ReadLine());
                double sideb = Double.Parse(Console.ReadLine());
                double area = sidea * sideb;
                Console.WriteLine($"{area:F3}");


            }
            else if (figure == "circle")
            {
                double r = Double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine($"{ area:F3}");
            }
            else if (figure == "triangle")
            {
                double sidea = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = sidea * (height / 2);
                Console.WriteLine($"{area:F3}");



            }
                

        }
    }
}
