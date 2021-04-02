using System;

namespace GozilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceforstatist = double.Parse(Console.ReadLine());


            double dekor = buget * 0.1;
            double totalclothesforstatist = statists * priceforstatist;
            if (statists >= 150)
            {
                totalclothesforstatist = totalclothesforstatist * 0.9;
            }
            double totalPrice = dekor + totalclothesforstatist;
            if (totalPrice > buget)
            {
                Console.WriteLine("Not enough money!");
                double dif = totalPrice - buget;
                Console.WriteLine($"Wingard needs {(totalPrice - buget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(buget - totalPrice):f2} leva left.");
            }







            
        }
    }
}
