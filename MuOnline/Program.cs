using System;
using System.Collections.Generic;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");

            int initialHealth = 100;
            int bitcoin = 0;



            for (int i = 0; i < rooms.Length; i++)
            {
                string[] tokens = rooms[i].Split();
                string comand = tokens[0];
                int number = int.Parse(tokens[1]);

                if (comand == "potion")
                {

                    int temporaryHealth = 0;
                    if (number + initialHealth <= 100)
                    {
                        
                        initialHealth = initialHealth + number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");



                    }
                    else
                    {
                        temporaryHealth = 100 - initialHealth;
                        initialHealth = initialHealth + temporaryHealth;
                        Console.WriteLine($"You healed for {temporaryHealth} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");

                    }
                    
                   


                }
                else if (comand == "chest")
                {
                    bitcoin = bitcoin + number;
                    Console.WriteLine($"You found {number} bitcoins.");



                }
                else
                {
                    initialHealth = initialHealth - number;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {comand}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {comand}.");
                        Console.WriteLine($"Best room: {i + 1}");

                        break;

                    }



                }
            }

            if (initialHealth > 0)
            {

                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {initialHealth}");

            }
        }
    }
}
