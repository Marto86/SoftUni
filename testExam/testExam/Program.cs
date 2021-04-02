using System;

namespace testExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double nesesaryHoney = double.Parse(Console.ReadLine());
            double honey = 0;

            while (true)
            {
                string beeName = Console.ReadLine();
                if (beeName == "Winter has come")
                {
                    break;
                }
                for (int mounth = 1; mounth <= 6; mounth++)
                {
                    double curentHoney = double.Parse(Console.ReadLine());
                    honey = honey + curentHoney;
                }
                if (honey >= nesesaryHoney)
                {
                    break;
                }
                if (honey < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }
            }
            if (honey >= nesesaryHoney)
            {
                Console.WriteLine($"Well done! Honey surplus {honey - nesesaryHoney:f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {nesesaryHoney - honey:f2}.");
            }
        }
    }
}
            
        
    
