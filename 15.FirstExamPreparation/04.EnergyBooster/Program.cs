using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numSets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (fruit)
            {
                case "Watermelon":
                    switch (size)
                    {
                        case "small":
                            price = numSets * (56 * 2);
                            break;

                        case "big":
                            price = numSets * (28.70 * 5);
                            break;
                    }
                    break;

                case "Mango":
                    switch (size)
                    {
                        case "small":
                            price = numSets * (36.66 * 2);
                            break;

                        case "big":
                            price = numSets * (19.60 * 5);
                            break;
                    }
                    break;

                case "Pineapple":
                    switch (size)
                    {
                        case "small":
                            price = numSets * (42.10 * 2);
                            break;

                        case "big":
                            price = numSets * (24.80 * 5);
                            break;
                    }
                    break;

                case "Raspberry":
                    switch (size)
                    {
                        case "small":
                            price = numSets * (20 * 2);
                            break;

                        case "big":
                            price = numSets * (15.20 * 5);
                            break;
                    }
                    break;

            }

            if (price < 400)
            {
                Console.WriteLine($"{price:F2} lv.");
            }
            else if (price >= 400 && price <= 1000)
            {
                double discount = price * 15 / 100;
                price = price - discount;
                Console.WriteLine($"{price:F2} lv.");
            }
            else if (price > 1000)
            {
                double discount = price * 50 / 100;
                price = price - discount;
                Console.WriteLine($"{price:F2} lv.");
            }
        }
    }
}
