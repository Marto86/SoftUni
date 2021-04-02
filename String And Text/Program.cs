using System;

namespace String_And_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBillder sb = new StringBillder(10000);

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("SoftUni");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
