using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
           

            for (int i = 0; i < num; i++)
            {
                int leftnum = int.Parse(Console.ReadLine());
                leftsum += leftnum;

            }
            for (int i = 0; i < num; i++)
            {
                int rightnum = int.Parse(Console.ReadLine());
                rightsum += rightnum;

            }
            if (rightsum == leftsum)
            {
                Console.WriteLine($"Yes, sum = {rightsum }" );
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightsum - leftsum)}");
            }
            


        }
    }
}
