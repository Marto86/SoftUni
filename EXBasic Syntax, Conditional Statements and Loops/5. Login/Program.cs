using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctpass = string.Empty;

            for (int i = username.Length -1; i >= 0; i--)
            {
                correctpass = correctpass + username[i];
                
            }
            string input = Console.ReadLine();
            int counter = 1;

            while (input != correctpass)
            {

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;
            }
            if (input == correctpass)
            {
                Console.WriteLine($"User {username} logged in.");
            }




        }

    }
}
