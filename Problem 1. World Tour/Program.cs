using System;
using System.Runtime.InteropServices;

namespace Problem_1._World_Tour
{
    class Program
    {
        static void Main(string[] tokens1)
        {
            string trip = Console.ReadLine();
            string temporary = trip;
            string comand = Console.ReadLine();

            while (comand != "Travel")
            {
                string [] tokens = comand.Split(":");
                if (tokens[0] == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string text = tokens[2];
                    if (index >=0 && index < trip.Length)
                    {
                        trip = trip.Insert(index, text);
                       // Console.WriteLine(trip);

                    }
                }

                if (tokens[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex < trip.Length && endIndex >= 0 && endIndex < trip.Length )
                    {
                       // string substr = trip.Substring(startIndex, endIndex);
                        trip = trip.Remove(startIndex, endIndex - startIndex + 1);
                       // Console.WriteLine(trip);
                    }
                }

                if (tokens[0] == "Switch")
                {
                    string old = tokens[1];
                    string newS = tokens[2];
                    if (temporary.Contains(old))
                    {
                        trip = trip.Replace(old, newS);
                      //  Console.WriteLine(trip);
                    }
                }

                comand = Console.ReadLine();

                Console.WriteLine(trip);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {trip}");

        }
    }
}
