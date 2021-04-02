using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while ("Craft!" != input)
            {
                string[] tokens = input.Split(" - ");
                string comand = tokens[0];
                string item = tokens[1];

                if ("Collect" == comand)
                {
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }

                }
                else if ("Drop" == comand)
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }

                }
                else if ("Combine Items" == comand)
                {
                    string[] items = item.Split(":");
                    string olditem = items[0];
                    string newitem = items[1];
                    int index = journal.IndexOf(olditem);

                    if (index >= 0)
                    {
                        journal.Insert(index + 1, newitem);
                    }

                }
                else if ("Renew" == comand)
                {

                    int index = journal.IndexOf(item);
                    if (index >= 0)
                    {
                        string element = journal[index];
                        journal.Remove(element);
                        journal.Add(element);
                    }

                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
