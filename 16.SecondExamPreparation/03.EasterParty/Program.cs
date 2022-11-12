using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGuests = int.Parse(Console.ReadLine());
            double priceForPerson = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            double cakePrice = budjet * 0.10;
            double price = 0.0;
            double priceWithDiscount = 0.0;

            if (numGuests < 10)
            {
                price = priceForPerson * numGuests;
            }
            else if (numGuests >= 10 && numGuests <= 15)
            {
                priceWithDiscount = priceForPerson * 0.15;
                priceForPerson = priceForPerson - priceWithDiscount;
                price = priceForPerson * numGuests;
            }
            else if (numGuests > 15 && numGuests <= 20)
            {
                priceWithDiscount = priceForPerson * 0.20;
                priceForPerson = priceForPerson - priceWithDiscount;
                price = priceForPerson * numGuests;
            }
            else if (numGuests > 20)
            {
                priceWithDiscount = priceForPerson * 0.25;
                priceForPerson = priceForPerson - priceWithDiscount;
                price = priceForPerson * numGuests;
            }
            price = price + cakePrice;

            if (budjet >= price)
            {
                double difference = budjet - price;
                Console.WriteLine($"It is party time! {difference:F2} leva left.");
            }
            else
            {
                double difference = price - budjet;
                Console.WriteLine($"No party! {difference:F2} leva needed.");
            }
        }
    }
}
