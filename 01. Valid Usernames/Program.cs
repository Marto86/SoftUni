using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] validUsernames = Console.ReadLine().Split(", ",StringSplitOptions.None).ToArray();

            foreach (var username in validUsernames)
            {
                if (validation(username))
                {
                    Console.WriteLine(username);
                }
            }



        }
        private static bool validation(string username)
        {

            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isValid = true;
            for (int i = 0; i < username.Length; i++)
            {
                char curr = username[i];

                
                if (!(char.IsLetterOrDigit(curr) || curr == '-' || curr == '_'))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;

        }
    }
}
