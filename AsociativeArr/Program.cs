using System;
using System.Collections.Generic;

namespace AsociativeArr
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, int>();

            people.Add("Desi", 22);
            people.Add("Ivan", 25 );
            people.Add("Simo", 32 );
            Console.WriteLine(people["Desi"]);
        }
    }
}
