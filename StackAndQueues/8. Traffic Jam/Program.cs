using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var pasingCars  = int.Parse(Console.ReadLine());
            var totalCarsPassed = 0;
            var cars = new Queue<string>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "green")
                {
                    for (int i = 0; i < pasingCars; i++)
                    {
                        if (cars.Any())
                        {
                            totalCarsPassed++;
                            var currentCar = cars.Dequeue();
                            Console.WriteLine($"{currentCar} passed!");
                        }
                    }
                    
                }
                else if (command == "end")
                {
                        
                    break;
                }
                else
                {
                    cars.Enqueue(command);
                }
               

            }

            Console.WriteLine($"{totalCarsPassed} car passed  the crossroads.");
        }
    }
}
