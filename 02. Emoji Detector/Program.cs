using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var emojiPatern = @"(\:\:|\*\*)[A-Z][a-z]{2,}(\:\:|\*\*)";
            var numberPatern = @"(?<number>\d)";

            var emojies = Regex.Matches(text, emojiPatern).ToList(); 
            var digits = Regex.Matches(text, numberPatern).ToList();
            long colnesFactor = 1;
            var finalEmojies = new List<String>();
            var coolnes = 0;

            foreach (var item in digits)
            {
                colnesFactor = colnesFactor * int.Parse(item.Groups["number"].Value);
            }

            foreach (var emojie in emojies)
            {
                for (int i = 0; i < emojie.Value.Length; i++)
                {
                    if (Char.IsLetter(emojie.Value[i]))
                    {
                        coolnes = coolnes + emojie.Value[i];
                    }
                }

                if (coolnes > colnesFactor)
                {
                    finalEmojies.Add(emojie.Value);
                }

                coolnes = 0;
            }

            Console.WriteLine($"Cool threshold: {colnesFactor}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            if (finalEmojies.Count > 0) ;
            {
                Console.WriteLine(string.Join(Environment.NewLine, finalEmojies));
            }
        }
    }
}
