using System;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           

            string pattern = @"\!([A-Z][a-z]{3,})!:\[([A-Za-z]{8,})\]";

            Regex regex = new Regex(pattern);


            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                var validMessage = regex.Match(message);

                if (validMessage.Success)
                {
                    string comand = validMessage.Groups[1].Value;
                    string inforamtion = validMessage.Groups[2].Value;
                    Console.Write(comand + ":" + " ");

                    foreach (var ch in inforamtion)
                    {
                        int result = ch;
                        Console.Write(result + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }






        }
        }
    }


