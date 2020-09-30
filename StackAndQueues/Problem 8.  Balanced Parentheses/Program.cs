using System;
using System.Collections.Generic;

namespace Problem_8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var parentheses = Console.ReadLine().ToCharArray();
            var openParent = new Stack<char>();
            var result = "YES";
            var balanced = true;
            if (parentheses.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var @char in parentheses)
            {
                if (@char == '(')
                {
                    openParent.Push(@char);
                }
                else if (@char == '{')
                {
                    openParent.Push(@char);
                }
                else if (@char == '[')
                {
                    openParent.Push(@char);
                }
                else if (@char == ')')
                {
                    balanced = CheckForMatch(openParent.Pop(), @char);
                }
                else if (@char == '}')
                {
                    balanced = CheckForMatch(openParent.Pop(), @char);
                }
                else if (@char == ']')
                {
                    balanced = CheckForMatch(openParent.Pop(), @char);
                }
                if (!balanced)
                {
                    result = "NO";
                    break;
                }


            }
            Console.WriteLine(result);
        }
        private static bool CheckForMatch(char open, char close)
        {
            var match = false;

            switch (open)
            {
                case '(':
                    if (close == ')') match = true;
                    break;
                case '{':
                    if (close == '}') match = true;
                    break;
                case '[':
                    if (close == ']') match = true;
                    break;
            }

            return match;
        }
    }
}
