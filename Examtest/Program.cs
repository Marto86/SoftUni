using System;
using System.Collections.Generic;
using System.Linq;

namespace Examtest

{
    public class Holder
    {
        public Holder(int rariti)
        {
            this.rariti = rariti;
            this.rating = new List<double>();
        }

        public int rariti { get; set; }
        public List<double> rating { get; set; }
        public double ratingavg { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var plants = new Dictionary<string, Holder>();

            for (int i = 0; i < n; i++)
            {
                string[] plantokens = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = plantokens[0];
                int rarity = int.Parse(plantokens[1]);

                if (plants.ContainsKey(plant))
                {
                    plants[plant].rariti = rarity;
                }
                else
                {
                    plants.Add(plant, new Holder(rarity));
                }
            }
            string comand = Console.ReadLine();
            while (comand != "Exhibition")
            {
               


                string[] tokkens = comand.Split(new[] { " - ", ":", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokkens[0] == "Rate")
                {
                    string plant = tokkens[1];
                    double rating = double.Parse(tokkens[2]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (tokkens[0] == "Update")
                {
                    string plant = tokkens[1];
                    int newRarity = int.Parse(tokkens[2]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].rariti = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (tokkens[0] == "Reset")
                {
                    string plant = tokkens[1];

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].rating = new List<double>();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
               

                comand = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                if (plant.Value.rating.Count != 0)
                {
                    plant.Value.ratingavg = plant.Value.rating.Average();
                }
            }

            foreach (var (plant, rating) in plants.OrderByDescending(x => x.Value.rariti).ThenByDescending(x => x.Value.ratingavg))
            {
                Console.WriteLine($"- {plant}; Rarity: {rating.rariti}; Rating: {rating.ratingavg:F2}");
            }
        }
    }

}

