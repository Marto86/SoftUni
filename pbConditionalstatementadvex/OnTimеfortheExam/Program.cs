using System;

namespace OnTimеfortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examStart = examHours * 60 + examMinutes; 
            int arrival = arrivalHours * 60 + arriveMinutes;
            int difference = (arrival - examStart); 
            int differenceHours = Math.Abs(difference / 60);
            int differenceMinutes = Math.Abs(difference) - differenceHours * 60;

            

            if (difference > 0) 
            {
                Console.WriteLine("Late");

                if (difference >= 60)
                {
                    Console.WriteLine($"{Math.Abs(differenceHours)}:{Math.Abs(differenceMinutes):00} hours after the start");
                }
                else if (difference < 60)
                {
                    Console.WriteLine($"{Math.Abs(differenceMinutes)} minutes after the start"); 
                }
            }
            else if (difference <= 0 && difference >= -30) 
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");

                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMinutes));
                }

            }
            else if (difference < -30) 
            {
                Console.WriteLine("Early");
                if (difference < -30 && difference > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMinutes));
                }
                else
                {

                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Abs(differenceHours), Math.Abs(differenceMinutes));
                }
            }
        }
    }
}
