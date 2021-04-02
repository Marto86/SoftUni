using System;

namespace yaardgreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double priceForYard = price * 7.61;
            double discount = priceForYard * 0.18;
            double finalPrice = priceForYard - discount;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");





        }

        }
    }

