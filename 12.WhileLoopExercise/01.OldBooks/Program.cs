using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int countBook = 0;
            while (currentBook != "No More Books")
            {
                if (currentBook == searchBook)
                {
                    break;
                }
                countBook++;
                currentBook = Console.ReadLine();
            }

            if (currentBook == searchBook)
            {
                Console.WriteLine($"You checked {countBook} books and found it.");
            }
            else if (currentBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBook} books.");
            }
        }
    }
}
