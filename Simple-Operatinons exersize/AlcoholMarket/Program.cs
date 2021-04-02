using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiPrice = whiskeyPrice / 2;
            double winePrice = rakiPrice - (rakiPrice * 0.4);
            double beerPrice = rakiPrice - (rakiPrice * 0.8);

            double rakiSum = rakiPrice * rakiLiters;
            double whiskeySum = whiskeyPrice * whiskeyLiters;
            double beerSum = beerPrice * beerLiters;
            double wineSum = winePrice * wineLiters;
            

            double totalSum = rakiSum + whiskeySum + wineSum + beerSum;
            Console.WriteLine("{0:F2}", totalSum);

        }
    }
}
