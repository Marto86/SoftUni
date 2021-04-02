using System;
using System.Collections.Generic;
using System.Linq;

namespace finalExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string instruction = Console.ReadLine();


            while (instruction != "Finish")
            {
                string[] comandarr = instruction.Split();
                string command = comandarr[0];

                if (command == "Replace")
                {
                    char currChar = char.Parse(comandarr[1]);
                    char newChar = char.Parse(comandarr[2]);

                    text = text.Replace(currChar, newChar);
                    Console.WriteLine(text);
                }

                if (command == "Cut")
                {
                    int startIndex = int.Parse(comandarr[1]);
                    int endIndex = int.Parse(comandarr[2]);

                    if (startIndex >= 0 && endIndex < text.Length)
                    {
                        int lenght = endIndex - startIndex + 1;
                        text = text.Remove(startIndex, lenght);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                if (command == "Make")
                {
                    if (comandarr[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }

                    if (comandarr[1] == "Lower")
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }

                }

                if (command == "Check")
                {
                    if (text.Contains(comandarr[1]))
                    {
                        Console.WriteLine($"Message contains {comandarr[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {comandarr[1]}");
                    }
                }

                if (command == "Sum")
                {
                    int startIndex = int.Parse(comandarr[1]);
                    int endIndex = int.Parse(comandarr[2]);

                    if (startIndex >= 0 && endIndex < text.Length)
                    {
                        int sum = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {

                            sum = sum + text[i];
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                instruction = Console.ReadLine();
            }
        }
    }
}
