using System;
using System.Diagnostics;

namespace repeat_string
{
    class Program
    {
        public static Stopwatch Stopwatch { get; private set; }

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                
                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write(word);
                }
                

            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
