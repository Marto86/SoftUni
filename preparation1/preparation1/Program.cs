using System;

namespace preparation1
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double sumPersonal = double.Parse(Console.ReadLine());

            double sumUnexpected = 0.3 * income;
            double savedMoney = income - sumPersonal - sumUnexpected;
            double totalMoney = month * savedMoney;
            double percent = savedMoney / income * 100;

            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
