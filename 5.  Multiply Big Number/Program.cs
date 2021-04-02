using System;
using System.Text;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            char[] number1 = Console.ReadLine().ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());

            int remainder = 0;
            for (int i = number1.Length - 1; i < 0; i--)
            {
                char currCh = number1[i];
                int curNum = int.Parse(currCh.ToString());
                int sum = (curNum * multiplier) + remainder;

                sb.Append(sum % 10);
                remainder = sum / 10;
            }
        }
    }
}
