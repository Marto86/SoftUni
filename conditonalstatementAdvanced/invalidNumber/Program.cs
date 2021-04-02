using System;

namespace invalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            if (num >= 100 && num <= 200 ) 
            {
                Console.WriteLine("");
            }
            else if (num == 0)
                {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
           
        }
    }
}
