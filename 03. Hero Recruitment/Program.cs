using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string,List<String>>();
            string input = Console.ReadLine();
            

            while (input != "End")
            {
                string[] splitInput = input.Split();
                string command = splitInput[0];
               


                if (command == "Enroll")
                {
                    string name = splitInput[1];
                    if (!heroes.ContainsKey(name))
                    {
                        heroes[name]= new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                       
                    }

                }

                if (command == "Learn")
                {
                    string name = splitInput[1];
                    string spell = splitInput[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (!heroes[name].Contains(spell))
                        {
                            heroes[name].Add(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }

                if (command == "Unlearn")
                {
                    string name = splitInput[1];
                    string spell = splitInput[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            heroes[name].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine("Heroes:");

            foreach (var( hero,spell)  in heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"== {hero}: {string.Join(", " , spell)}");

                
            }

        }

    }
}
