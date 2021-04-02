using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var perimeter = 2 * (Math.Abs(x2 - x1) + Math.Abs(y1 - y2));
            var area= Math.Abs(x2 - x1) * Math.Abs(y1 - y2);

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
            
            




        }
    }
}
