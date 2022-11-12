using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            double price = 0.0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    price = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    price = 14;
                    break;
                case "Sunday":
                case "Saturday":
                    price = 16;
                    break;
            }

            Console.WriteLine(price);
        }
    }
}
