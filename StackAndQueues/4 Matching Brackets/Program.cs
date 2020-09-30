using System;
using System.Collections;
using System.Collections.Generic;

namespace _4_Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var stack= new Stack<int>();

            for (int i = 0; i < text.Length ; i++)
            {
                var symbol = text[i];
                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    var indexOfopeningbracket = stack.Pop();
                    var result = text.Substring(indexOfopeningbracket, i - indexOfopeningbracket + 1);
                    Console.WriteLine(result);
                }
            }

            
        }
    }
}
