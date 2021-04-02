using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int tempNum = num;
            string stringNum = "";
            stringNum = stringNum + num;
            int sum = 0;



            for (int i = 0; i < stringNum.Length; i++)
            {
                int curNum = tempNum % 10;
                tempNum = (tempNum - curNum) / 10;

                int facotrial = 1;
                for (int j = 1; j <= curNum; j++)
                {
                    facotrial = facotrial * j;
                }

                sum = sum + facotrial;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
