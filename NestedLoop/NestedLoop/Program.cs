using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTime = false;

            for (int hours = 0; hours <= 23; hours++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    if (hours == 7 && min == 30)
                    {
                        Console.Beep(277, 1600);
                        isTime = true;
                        break;
                    }
                    Console.WriteLine($"{hours:d2}:{min:d2}");
                }
                if (isTime)
                {
                    break;
                }

            }
        }
    }
}
