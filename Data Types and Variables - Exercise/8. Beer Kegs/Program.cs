using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string nameModel = " ";
            double radius = 0.0;
            int hight = 0;
            double volume = 0;
            string biggestVolume = " " ;
            double volume1 = 0.0 ;

            for (int i = 0; i < number; i++)
            {
                nameModel = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                hight = int.Parse(Console.ReadLine());
                volume1 = Math.PI * radius * radius * hight;
                if (volume1 > volume)
                {
                    volume = volume1;
                    biggestVolume = nameModel;
                }
            }
            Console.WriteLine(biggestVolume);
        }
    }
}
