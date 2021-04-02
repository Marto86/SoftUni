using System;

namespace honeyCombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beeCount = int.Parse(Console.ReadLine());
            int flowerCount = int.Parse(Console.ReadLine());

            double honey = beeCount * flowerCount * 0.21;
            double honeleft = honey % 100;
            double honeycomb = (honey - honeleft) / 100;

            Console.WriteLine($"{honeycomb} honeycombs filled.");
            Console.WriteLine($"{honeleft:f2} grams of honey left.");
            



        }
    }
}
