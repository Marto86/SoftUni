using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte charsCount = byte.Parse(Console.ReadLine());
            int sum = 0;
            while (charsCount > 0)
            {
                sum += char.Parse(Console.ReadLine());
                charsCount--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
