using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] directions = Console.ReadLine().Split(" ").ToArray(); ;
                
                if (directions[0] == "register")
                {
                    string name = directions[1];
                    string license = directions[2];
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[name]}");
                    }
                    else
                    {
                        users.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                }
                if (directions[0] == "unregister")
                {
                    string name = directions[1];

                    if (!users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        
                    }
                    else
                    {

                        users.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }


                }
            }
                foreach (var item in users)
                {
                    Console.WriteLine($"{item.Key} => {item.Value}");
                }
        }
    }
}
