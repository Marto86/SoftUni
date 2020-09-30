using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Problem_3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "1")
                {
                    var element = int.Parse(cmdArgs[1]);
                    numbers.Push(element);
                }
                else if (cmdType == "2")
                {
                    if (numbers.Any())
                    {
                        numbers.Pop();
                    }

                }
                else if (cmdType == "3")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Max());
                    }

                }
                else if (cmdType == "4")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
                
                    
                
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
