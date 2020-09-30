using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem_9.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            var oldVersion = new Stack<string>();


            for (int i = 0; i < n ;i++)
            {
                var commands = Console.ReadLine().Split();
                var command = int.Parse(commands[0]);

                if (command == 1)
                {
                    oldVersion.Push(text.ToString());
                    var tx = commands[1];
                    text.Append(tx);

                }
                else if (command == 2)
                {
                    var elementCount = int.Parse(commands[1]);
                    oldVersion.Push(text.ToString());
                    text.Remove(text.Length - elementCount, elementCount);

                }
                else if (command == 3 )
                {
                    var index = int.Parse(commands[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (command == 4)
                {
                    text.Clear();
                    text.Append(oldVersion.Pop());
                }

            }
        }
    }
}
