using System;
using System.Runtime.CompilerServices;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string roomTipe = Console.ReadLine();
            string value = Console.ReadLine();

            double nights = days - 1;

            switch (roomTipe)
            {
                case "room for one person":
                    double totalPriceForRomm = nights * 18;
                    if (value == "positive")
                    {
                        double totalPriceWithValue = totalPriceForRomm + (totalPriceForRomm * 0.25);
                        Console.WriteLine($"{totalPriceWithValue:F2}");
                    }
                    else if (value == "negative")
                    {
                        double totalPriceWithValue = totalPriceForRomm - (totalPriceForRomm * 0.1);
                        Console.WriteLine($"{totalPriceWithValue:F2}");
                    }
                    break;


                case "apartment":
                    double totalPriceApartment = nights * 25;
                    double discount = 0.0;
                    double price = 0.0;

                    if (days < 10)
                    {
                        discount = totalPriceApartment * 0.30;
                        price = totalPriceApartment - discount;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        discount = totalPriceApartment * 0.35;
                        price = totalPriceApartment - discount;
                    }
                    else if (days >= 15)
                    {
                        discount = totalPriceApartment * 0.50;
                        price = totalPriceApartment - discount;
                    }

                    if (value == "positive")
                    {
                        double totalPriceWithValue = price + (price * 0.25);
                        Console.WriteLine($"{totalPriceWithValue:F2}");
                    }
                    else if (value == "negative")
                    {
                        double totalPriceWithValueN = price - (price * 0.1);
                        Console.WriteLine($"{totalPriceWithValueN:F2}");
                    }

                    break;
                case "president apartment":

                    double totalPricePresidentApartment = nights * 35;
                    double discountt = 0.0;
                    double pricee = 0.0;

                    if (days < 10)
                    {
                        discountt = totalPricePresidentApartment * 0.10;
                        pricee = totalPricePresidentApartment - discountt;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        discountt = totalPricePresidentApartment * 0.15;
                        pricee = totalPricePresidentApartment - discountt;
                    }
                    else if (days >= 15)
                    {
                        discountt = totalPricePresidentApartment * 0.20;
                        pricee = totalPricePresidentApartment - discountt;
                    }

                    if (value == "positive")
                    {
                        double totalPriceWithValue = pricee + (pricee * 0.25);
                        Console.WriteLine($"{totalPriceWithValue:F2}");
                    }
                    else if (value == "negative")
                    {
                        double totalPriceWithValueN = pricee - (pricee * 0.1);
                        Console.WriteLine($"{totalPriceWithValueN:F2}");
                    }

                    break;
            }
        }
    }
}
