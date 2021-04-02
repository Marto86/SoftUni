using System;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long temporary = 0;
            string comand = Console.ReadLine();
            bool check = comand.Contains("end");

            while (check != true)  
            {
                check = comand.Contains("end");
                bool multiply = comand.Contains("multiply");
                bool swap = comand.Contains("swap");
                bool decrease = comand.Contains("decrease");

                if (swap == true)
                {
                    string[] tokens = comand.Split();
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    temporary = input[index1];
                    input[index1] = input[index2];
                    input[index2] = temporary;
                }
                else if (multiply == true)
                {
                    string[] tokens = comand.Split();
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    input[index1] =input[index1]* input[index2];
                }
                else if (decrease == true)
                {
                    input = Array.ConvertAll(input, x => x - 1);
                }
                else if (check == true)
                {
                    check = true;
                    break;
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
