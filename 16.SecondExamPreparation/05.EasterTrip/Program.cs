using System;
using System.Security.Cryptography;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string days = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (destination)
            {
                case "France":
                    if (days == "21-23")
                    {
                        price = numNights * 30;
                    }
                    else if (days == "24-27")
                    {
                        price = numNights * 35;
                    }
                    else if (days == "28-31")
                    {
                        price = numNights * 40;
                    }
                    break;

                case "Italy":
                    if (days == "21-23")
                    {
                        price = numNights * 28;
                    }
                    else if (days == "24-27")
                    {
                        price = numNights * 32;
                    }
                    else if (days == "28-31")
                    {
                        price = numNights * 39;
                    }
                    break;

                case "Germany":
                    if (days == "21-23")
                    {
                        price = numNights * 32;
                    }
                    else if (days == "24-27")
                    {
                        price = numNights * 37;
                    }
                    else if (days == "28-31")
                    {
                        price = numNights * 43;
                    }
                    break;
            }

            Console.WriteLine($"Easter trip to {destination} : {price:F2} leva.");
        }
    }
}
