using System;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordtoremove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(wordtoremove))
            {
                int sindex = text.IndexOf(wordtoremove);
                text = text.Remove(sindex, wordtoremove.Length) ;
            }

            Console.WriteLine(text);
        }
    }
}
