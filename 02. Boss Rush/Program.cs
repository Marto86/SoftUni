using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var regex =new Regex(@"\|(?<Name>[A-Z]{4,})\|\:\#(?<Title>[A-Za-z]+\s[A-Za-z]+)\#");
                var mach = regex.Match(input);

                if (mach.Success)
                {
                    var name = mach.Groups["Name"].Value;
                    var title = mach.Groups["Title"].Value;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                    
                }




            }

        }

    }
}
