using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                for (int r = 0; r < i; r++)
                {
                Console.Write(i + " ");

                }
                Console.WriteLine(  );
            }
        }
    }
}
