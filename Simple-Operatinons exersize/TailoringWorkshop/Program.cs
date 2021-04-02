using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());
            double recArea = n * (tableLenght + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double squareArea = n * (tableLenght / 2) * (tableLenght / 2);
            double priceUSD = recArea * 7 + squareArea * 9;
            double priceBGN = priceUSD * 1.85;
            Console.WriteLine("{0:f2} USD", priceUSD);
            Console.WriteLine("{0:f2} BGN", priceBGN);
        }
    }
}
