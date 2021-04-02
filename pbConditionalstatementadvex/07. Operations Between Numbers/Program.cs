using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operate = Console.ReadLine();
            double result = 0;



            if (operate == "+")
            {


                result = N1 + N2;
                if (result % 2 == 0)

                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");

                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");
                }

            }
            else if (operate == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)

                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");

                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");
                }
            }
            else if (operate == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)

                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");

                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }
            }
            else if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (operate == "/")
            {
                result = N1 / N2;

                Console.WriteLine($"{N1} / {N2} = {result:F2}");
            }
            else if (operate == "%")
            {


                result = N1 % N2;

                Console.WriteLine($"{N1} % {N2} = {result}");
            }

           
        }

    }
}
