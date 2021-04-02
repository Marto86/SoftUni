using System;
using System.Text;

namespace BubbleSortAlgorithmVisualization
{
    public class StartUp
    {
        static void Main()
        {
            var array = ReadArray();
            BubbleSort(array);
            Console.WriteLine(PrintElements(array));
        }

        public static string PrintElements(int[] arr)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append($"{arr[i]}, ");
            }

            return sb.ToString().TrimEnd();
        }

        public static int[] ReadArray()
        {
            Console.Write("Read Elements On Array: ");

            var elementsOnArray = int.Parse(Console.ReadLine());

            var randomNumGen = new Random();

            var array = new int[elementsOnArray];

            for (int i = 0; i < array.Length; i++)
            {
                var randomNum = randomNumGen.Next(1, 101);

                array[i] = randomNum;
            }

            return array;
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];

                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}