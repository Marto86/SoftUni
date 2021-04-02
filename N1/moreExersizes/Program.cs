using System;

namespace moreExersizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencilPack = int.Parse(Console.ReadLine());
            int markerlPack = int.Parse(Console.ReadLine());
            double cleanSubs = double.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double pencilPrice = 5.80;
            double markerPrice = 7.20;
            double cleanSubsPrice = 1.20;

            double totalPrice = (pencilPack * pencilPrice) + (markerlPack * markerPrice) + (cleanSubs * cleanSubsPrice);
            double discountPrice = totalPrice - (totalPrice * discountPercent / 100);

            Console.WriteLine($"{discountPrice:f3}");
            
            
        }
    }
}
