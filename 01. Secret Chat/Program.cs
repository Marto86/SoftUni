using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks.Sources;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            var activationKey = Console.ReadLine();
            var input = Console.ReadLine();


            while (input != "Generate")
            {
                string[] newkey = activationKey.Split().ToArray();
                string[] tokens = input.Split(">>>");
                var comand = tokens[0];

                if (comand == "Contains")
                {
                    string selected = tokens[1];
                    if (activationKey.Contains(selected))
                    {
                        Console.WriteLine($"{activationKey} contains {selected}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (comand == "Flip")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                   

                    if (tokens[1] == "Upper")
                    {
                        var subString = activationKey.Substring(startIndex, endIndex - startIndex);
                        activationKey = Regex.Replace(activationKey, subString, subString.ToUpper());


                    }
                    else
                    {
                        var subStrin = activationKey.Substring(startIndex, endIndex - startIndex);
                        activationKey = Regex.Replace(activationKey, subStrin, subStrin.ToLower());
                    }

                    Console.WriteLine(activationKey);
                    break;
                    ;
                }

                if (comand ==  "Slice")
                {
                    
                   var startIndex = int.Parse(tokens[1]);
                   var endIndex = int.Parse(tokens[2]);
                   activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                   Console.WriteLine(activationKey);
                   break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");


        }



    }
}
