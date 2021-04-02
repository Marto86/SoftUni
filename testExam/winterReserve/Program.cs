
namespace HoneyWinterReserves
    {
        class Program
        {
            static void Main(string[] args)
            {
                

                double neededHoney = double.Parse(Console.ReadLine());
                double honey = 0;

                while (true)
                {
                    string beeName = Console.ReadLine();
                    if (beeName == "Winter has come")
                    {
                        break;
                    }
                    for (int months = 1; months <= 6; months++)
                    {
                        double currHoney = double.Parse(Console.ReadLine());
                        honey += currHoney;
                    }
                    if (honey >= neededHoney)
                    {
                        break;
                    }
                    if (honey < 0)
                    {
                        Console.WriteLine($"{beeName} was banished for gluttony");
                    }
                }
                if (honey >= neededHoney)
                {
                    Console.WriteLine($"Well done! Honey surplus {honey - neededHoney:f2}.");
                }
                else
                {
                    Console.WriteLine($"Hard Winter! Honey needed {neededHoney - honey:f2}.");
                }
            }
        }
    }

    

