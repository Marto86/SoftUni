using System;
using System.Linq;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            string[] fileArgs = file.Split('\\', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] fileInfo = fileArgs.Last().Split('.', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] fileNameArgs = fileInfo.Take(fileInfo.Length - 1).ToArray();

            string fileName = string.Join('.', fileNameArgs);
            string fileExtension = fileInfo.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
