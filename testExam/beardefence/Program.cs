using System;



namespace BeehiveDefense
    {
        class Program
        {
            static void Main(string[] args)
            {
                

                int Bees = int.Parse(Console.ReadLine());
                int healthBee = int.Parse(Console.ReadLine());
                int atacBear = int.Parse(Console.ReadLine());
                int atackbee = 5;
                while (Bees >= 100 && healthBee > 0)
                {
                    Bees -= atacBear;
                    healthBee -= Bees * atackbee;
                }
                if (healthBee > 0 && Bees > 0)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {Bees}.");
                }
                else if (healthBee > 0 && Bees <= 0)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {0}.");
                }
                else
                {
                    Console.WriteLine($"Beehive won! Bees left {Bees}.");
                }
            }
        }
    }

