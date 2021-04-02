using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var carscount = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> cars = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < carscount; i++)
            {
                var carInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                var name = carInfo[0];
                var milage = int.Parse(carInfo[1]);
                var fuel = int.Parse(carInfo[2]);
                cars.Add(name,new Dictionary<string, int>()
                {
                    {"mileage",milage},
                    {"fuel",fuel}
                });
            }

            var command = Console.ReadLine();
            while (command != "Stop")
            {
                var tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var carname = tokens[1];
                var distance = int.Parse(tokens[2]);
                var fuel = int.Parse(tokens[3]);
                switch (action)
                {
                    case "Drive":
                       

                        var carFuel = cars[carname]["fuel"];
                        if (fuel > carFuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[carname]["milage"] += distance;
                            cars[carname]["fuel"] -= fuel;
                            Console.WriteLine($"{carname} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (cars[carname]["milage"] > 100000 )
                        {
                            Console.WriteLine($"Time to sell the {carname}!");
                            cars.Remove(carname);
                        }

                        break;
                    case "Refuel":
                        var fuelToadd = int.Parse(tokens[2]);
                        var currFuel = cars[carname]["fuel"];
                        if (fuelToadd + currFuel > 75)
                        {
                            fuelToadd = 75 - currFuel;
                        }

                        cars[carname]["fuel"] += fuelToadd;
                        Console.WriteLine($"{carname} refueled with {fuelToadd} liters");
                        
                        break;
                    case "Revert":
                        var kilometers = int.Parse(tokens[2]);

                        cars[carname]["milege"] -= kilometers;
                        if (cars[carname]["milege"] < 10000)
                        {
                            cars[carname]["milege"] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carname} mileage decreased by {kilometers}");
                            
                        }
                        break;
                        

                }
            }

            var ordered = cars.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key);
            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]}kms, Fuel in the tank: {car.Value["fuel"]}lt.");
            }

        }
    }

    
}
