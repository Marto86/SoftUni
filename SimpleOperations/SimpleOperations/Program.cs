using System;

namespace SimpleOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //&quot;You are &lt;firstName&gt; &lt;lastName&gt;, a &lt;age&gt;-years old person from &lt;town&gt;.&quot;
            string frirstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are " + frirstName + " " + lastName + ", a " + age + "-years old person from " + town+".");



        }
    }
}
