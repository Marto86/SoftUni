using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfcampaign = int.Parse(Console.ReadLine());
            int numberOfCooks = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double incomesFromCakes = numberOfCakes * 45;
            double incomesFromWaffles = numberOfWaffles * 5.80;
            double incomesFromPancakes = numberOfPancakes * 3.20;

            double incomesForADay = (incomesFromCakes + incomesFromPancakes + incomesFromWaffles) * numberOfCooks;
            double totalIncomes = incomesForADay * daysOfcampaign;
            double earnings = totalIncomes - (0.125 * totalIncomes);

            Console.WriteLine($"{earnings:f2}");
        }
    }
}
