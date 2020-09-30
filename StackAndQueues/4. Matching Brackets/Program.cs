using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);
            while (true)
            {
                var command = Console.ReadLine().ToLower().Split();


                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    var totalElements = int.Parse(command[1]);
                    if (stack.Count >= totalElements)
                    {


                        for (int i = 0; i < totalElements; i++)
                        {
                            
                                stack.Pop();
                            

                        }
                    }
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
