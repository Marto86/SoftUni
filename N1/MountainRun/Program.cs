using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double recordinSec = double.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            double SecForMeter = double.Parse(Console.ReadLine());

            double time = distanceM * SecForMeter;
            double slowingTime = Math.Floor(distanceM / 50)*30;
            double totalTime = time + slowingTime;

            if (recordinSec > totalTime)
            {

                Console.WriteLine($" Yes! The new record is {totalTime:F2} seconds.");
            }
            else if(recordinSec <= totalTime)
            {
                double timeDif = totalTime - recordinSec;
                Console.WriteLine($"No! He was {timeDif:F2} seconds slower.");
            }

        }
    }
}
