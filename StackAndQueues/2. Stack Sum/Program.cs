using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> result = new Stack<string>(input.Reverse());

            int tempResul;
            while (result.Count > 1 )
            {
                int firstNumber = int.Parse(result.Pop());
                string operation = result.Pop();
                int secNumber = int.Parse(result.Pop());

                tempResul = operation switch
                {
                    "+" => firstNumber + secNumber,
                    "-" => firstNumber - secNumber,
                    _ => 0
                };
                result.Push(tempResul.ToString());
            }
            Console.WriteLine(result.Pop());
        }
    }
}
