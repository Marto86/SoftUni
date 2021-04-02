using System;

namespace squarearea
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int area = side * side;
            
            Console.WriteLine(area);

        }
    }
}
