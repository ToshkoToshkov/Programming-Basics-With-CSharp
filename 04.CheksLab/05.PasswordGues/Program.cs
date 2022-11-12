using System;

namespace PasswordGues
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string greatPassword = "s3cr3t!P@ssw0rd";

            if (password == greatPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}