using System;
using System.Linq;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string allDigits = "";
            string allLeters = "";
            string evrythingElse = "";

            foreach (var symobol in text)
            {
                if (char.IsDigit(symobol))
                {
                    allDigits = allDigits + symobol;
                }
                else if (char.IsLetter(symobol))
                {
                    allLeters = allLeters + symobol;
                }
                else
                {
                    evrythingElse = evrythingElse + symobol;
                }


            }
            Console.WriteLine(allDigits);
            Console.WriteLine(allLeters);
            Console.WriteLine(evrythingElse);
        }
    }
}
