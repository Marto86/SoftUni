using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int colum = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            double income = 0;

            if (type == "Premiere")
            {
                income = colum * rows * 12.00;

            }
            else if (type == "Normal")
            {
                income = colum * rows * 7.5;

            }
            else if (type == "Discount")
            {
             income = colum * rows * 5.0;
            }



            Console.WriteLine($"{income:f2} leva");
        }



       
    }
}
