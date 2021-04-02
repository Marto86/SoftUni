using System;

namespace worldSwimingrecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecord = Double.Parse(Console.ReadLine());
            double meters = Double.Parse(Console.ReadLine());
            double timeseconds = Double.Parse(Console.ReadLine());

            double speed = meters * timeseconds;
            double current = (Math.Floor(meters / 15)) * 12.5;
            double totaltime = speed + current;

            if (oldRecord <= totaltime)
            {
                double difference = Math.Abs(oldRecord - totaltime);
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
            else if (oldRecord > totaltime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {(totaltime):f2} seconds.");
            }
        }
    }
}
