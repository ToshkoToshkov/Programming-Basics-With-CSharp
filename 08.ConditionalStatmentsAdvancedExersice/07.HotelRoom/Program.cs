using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;
            double discountStudio = 0.0;
            double discountApartment = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = nights * 50;
                    priceApartment = nights * 65;
                    if (nights > 7 && nights < 14)
                    {
                        discountStudio = priceStudio * 0.05;
                        priceStudio = priceStudio - discountStudio;
                    }
                    else if (nights > 14)
                    {
                        discountStudio = priceStudio * 0.30;
                        priceStudio = priceStudio - discountStudio;

                    }
                    break;

                case "June":
                case "September":
                    priceStudio = nights * 75.20;
                    priceApartment = nights * 68.70;
                    if (nights > 14)
                    {
                        discountStudio = priceStudio * 0.20;
                        priceStudio = priceStudio - discountStudio;
                    }
                    break;

                case "July":
                case "August":
                    priceApartment = nights * 77;
                    priceStudio = nights * 76;
                    break;

                    if (nights > 14)
                    {
                        discountApartment = priceApartment * 0.10;
                        priceApartment = priceApartment - discountApartment;
                    }

                    Console.WriteLine("Apartment: " + ($"{priceApartment:F2}") + " lv.");
                    Console.WriteLine("Studio: " + ($"{priceStudio:F2}") + " lv.");

            }
        }
    }
}
