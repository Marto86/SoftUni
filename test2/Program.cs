

using System;
using System.Collections.Generic;
using System.Linq;

namespace vehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();


            while (command != "end")
            {

                string[] vehicleInfo = command.Split("/").ToArray();

                if (vehicleInfo[0] == "Truck")
                {

                    Truck truck = new Truck();

                    truck.Brand = vehicleInfo[1];
                    truck.Model = vehicleInfo[2];
                    truck.Weight = int.Parse(vehicleInfo[3]);
                    trucks.Add(truck);

                }
                else
                {
                    Car car = new Car();

                    car.Brand = vehicleInfo[1];
                    car.Model = vehicleInfo[2];
                    car.HorsePower = int.Parse(vehicleInfo[3]);
                    cars.Add(car);


                }
                command = Console.ReadLine();

            }

            List<Car> carSorted = cars.OrderBy(car => car.Brand).ToList();
            List<Truck> truckSorted = trucks.OrderBy(truck => truck.Brand).ToList();



            if (carSorted.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car car in carSorted)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - { car.HorsePower}hp");
            }

            if (truckSorted.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in truckSorted)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - { truck.Weight}kg");
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

        }
        class CatalogVehicle
        {
            public List<Car> cars { get; set; }
            public List<Truck> Тrucks { get; set; }
        }

    }
}
