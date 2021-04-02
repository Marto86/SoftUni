using System;
using System.Text;

namespace PaswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var command = Console.ReadLine();

            while (command != "Done")
            {
                if (command.Contains("TakeOdd"))
                {
                    StringBuilder oddChars = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        oddChars.Append(password[i]);

                    }

                    password = oddChars.ToString();
                    Console.WriteLine(password);
                }

                if (command.Contains("Cut"))
                {
                    var splited = command.Split();
                    int index = int.Parse(splited[1]);
                    int lenght = int.Parse(splited[2]);

                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }

                if (command.Contains("Substitute"))
                {
                    var splited = command.Split();
                    var old = splited[1];
                    var newString = splited[2];
                    if (password.IndexOf(old) >= 0)
                    {
                        password = password.Replace(old, newString);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                    

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
