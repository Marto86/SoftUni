using System;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double umbrelaPrice = 2 * towelPrice  / 3;
            double flipflopsPrice = umbrelaPrice * 0.75;
            double beachBag = (towelPrice + flipflopsPrice) / 3 ;

            double totalSum = umbrelaPrice + flipflopsPrice + beachBag + towelPrice;
            totalSum = totalSum - (percentDiscount / 100.0) * totalSum;


            if (budget >= totalSum)
            {
                double leftMoney = budget - totalSum;
                Console.WriteLine($"Annie's sum is {totalSum:F2} lv. She has {leftMoney:F2} lv. left.");
            }
            else
            {
                double missingMoney = totalSum - budget;
                Console.WriteLine($"Annie's sum is {totalSum:F2} lv. She needs {missingMoney:F2} lv. more.");
            }



        }
    }
}
