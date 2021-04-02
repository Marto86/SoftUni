
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace companyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyID = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                var command = input.Split(" -> ").ToArray();
                var companyName = command[0];
                var employeeID = command[1];

                if (companyID.ContainsKey(companyName) == false)
                {
                    companyID.Add(companyName, new List<string>());
                }
                if (companyID[companyName].Contains(employeeID) == false)
                {
                    companyID[companyName].Add(employeeID);
                }
                input = Console.ReadLine();
            }
            var result = companyID.OrderByDescending(x => x.Key).Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var element in item.Value)
                {
                    Console.WriteLine($"-- {element}");
                }
            }
        }
    }
}