using System;
using System.Linq;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] wordsToBann = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < wordsToBann.Length; i++)
            {
                string wordToCensur = wordsToBann[i];

                while (text.Contains(wordToCensur))
                {
                    text = text.Replace(wordToCensur, new string('*', wordToCensur.Length));
                }
            }

            Console.WriteLine(text);


        }
    }
}
