using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var myStack = new Stack<char>(input);
           

            while (myStack.Any())
            {
                Console.Write(myStack.Pop());
            }
        }
    }
}
