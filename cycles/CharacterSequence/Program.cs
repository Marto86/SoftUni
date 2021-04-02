using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum > maxNum)
                {
                    maxNum = currNum;
                }
                if (currNum < minNum)
                {
                    minNum = currNum;
                }
            }

            Console.WriteLine($"Max number: {maxNum}" ); 
            Console.WriteLine($"Min number: {minNum}" ); 
        }
    }
}
