using System;
using System.Linq;

namespace evenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string[] evenwords = words.Where(word => word.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(" ",evenwords));


        }
    }
}
