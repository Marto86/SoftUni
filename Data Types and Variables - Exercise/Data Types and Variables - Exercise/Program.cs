﻿using System;

namespace Data_Types_and_Variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int totalResult = 0;

            totalResult = (((firstNum + secondNum) / thirdNum)) * fourthNum;
           

            Console.WriteLine(totalResult);


        }



    }

}
