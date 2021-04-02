using System;
using System.Threading.Channels;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            string result = " ";
            for (int i = first; i <= last; i++)
            {
                result = result + (char)i + " ";
            }

            Console.WriteLine(result);
        }
    }
}
