using System;
using System.IO;
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
            

            while (comand != "end")  
            {
                check = comand.Contains("end");
                bool multiply = comand.Contains("multiply");
                bool swap = comand.Contains("swap");
                bool decrease = comand.Contains("decrease");

                if (comand == "swap")
                {
                    string[] positions = comand.Split();
                    int pos1 = int.Parse(positions[1]);
                    int pos2 = int.Parse(positions[2]);

                    temporary = input[pos1];
                    input[pos1] = input[pos2];
                    input[pos2] = temporary;
                }
                else if (comand == "multiply")
                {
                    string[] positions = comand.Split();
                    int pos1 = int.Parse(positions[1]);
                    int pos2 = int.Parse(positions[2]);

                    input[pos1] *= input[pos2];
                }
                else if (comand == "decrease")
                {
                    input = Array.ConvertAll(input, x => x - 1);
                }
                else if (comand == "end")
                {
                   
                    break;
                }
                
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
