using System;

namespace paassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = (Console.ReadLine());

            if (x ==  "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (x != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
