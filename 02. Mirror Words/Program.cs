using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validWords = new List<string>();
            var input = Console.ReadLine();
            string pattern = @"([@,#])(?<word>\[a-zA-Z]{3,})(\1)(\1)(?<word2>[a-zA-Z]{3,})(\1)";

            MatchCollection maches = Regex.Matches(input, pattern);


            foreach (Match mach in maches)
            {
                var word1 = mach.Groups["word1"].Value;
                var word2 = mach.Groups["word2"].Value;
                var reversed = string.Concat(word1.Reverse());
                if (reversed == word2)
                {
                    validWords.Add($"{word1} <=> {word2}");
                }
            }

            if (maches.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{maches.Count} word pairs found!");
            }

            if (validWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine(string.Join(" <=> ", validWords));
            }
        }
    }
}
