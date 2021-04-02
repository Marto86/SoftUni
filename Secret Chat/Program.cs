using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != "Reveal")
            {
                var command = input.Split(":|:");
                var action = command[0];
                switch (action)
                {
                    case "InsertSpace":
                        var index = int.Parse(command[1]);
                        msg = msg.Insert(index, " ");
                        Console.WriteLine(msg);
                        break;
                    case "Reverse":
                        var subString = command[1];
                        if (msg.Contains(subString))
                        {
                            index = msg.IndexOf(subString);
                            var subLength = subString.Length;
                            msg = msg.Remove(index, subLength);
                            var subStringChar = subString.ToCharArray();
                            var reversed = subStringChar.Reverse();
                            var final = string.Join("", reversed);
                            msg += final;
                            Console.WriteLine(msg);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        subString = command[1];
                        var replacement = command[2];
                        msg = Regex.Replace(msg, subString, replacement);
                        Console.WriteLine(msg);
                        break;
                }
                input = Console.ReadLine();
               
            }

            Console.WriteLine($"You have a new text message: {input}"
            );
        }
    }
}
