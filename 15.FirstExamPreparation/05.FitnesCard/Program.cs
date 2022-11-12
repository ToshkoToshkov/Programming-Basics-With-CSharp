using System;

namespace FitnesCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;

            switch (sport)
            {
                case "Gym":
                    if (gender == 'm')
                    {
                        if (age <= 19)
                        {
                            double discount = 42 * 20 / 100;
                            price = 42 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 42;
                        }
                    }
                    else if (gender == 'f')
                    {
                        if (age <= 19)
                        {
                            double discount = 35 * 20 / 100;
                            price = 35 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 35;
                        }
                    }
                    break;

                case "Boxing":
                    if (gender == 'm')
                    {
                        if (age <= 19)
                        {
                            double discount = 41 * 20 / 100;
                            price = 41 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 41;
                        }
                    }
                    else if (gender == 'f')
                    {
                        if (age <= 19)
                        {
                            double discount = 37 * 20 / 100;
                            price = 37 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 37;
                        }
                    }
                    break;

                case "Yoga":
                    if (gender == 'm')
                    {
                        if (age <= 19)
                        {
                            double discount = 45 * 20 / 100;
                            price = 45 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 45;
                        }
                    }
                    else if (gender == 'f')
                    {
                        if (age <= 19)
                        {
                            double discount = 42 * 20 / 100;
                            price = 42 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 42;
                        }
                    }
                    break;

                case "Zumba":
                    if (gender == 'm')
                    {
                        if (age <= 19)
                        {
                            double discount = 34 * 20 / 100;
                            price = 34 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 34;
                        }
                    }
                    else if (gender == 'f')
                    {
                        if (age <= 19)
                        {
                            double discount = 31 * 20 / 100;
                            price = 31 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 31;
                        }
                    }
                    break;

                case "Dances":
                    if (gender == 'm')
                    {
                        if (age <= 19)
                        {
                            double discount = 51 * 20 / 100;
                            price = 51 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 51;
                        }
                    }
                    else if (gender == 'f')
                    {
                        if (age <= 19)
                        {
                            double discount = 53 * 20 / 100;
                            price = 53 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 53;
                        }
                    }
                    break;

                case "Pilates":
                    if (gender == 'm')
                    {
                        if (age <= 19)
                        {
                            double discount = 39 * 20 / 100;
                            price = 39 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 39;
                        }
                    }
                    else if (gender == 'f')
                    {
                        if (age <= 19)
                        {
                            double discount = 37 * 20 / 100;
                            price = 37 - discount;
                        }
                        else if (age > 19)
                        {
                            price = 37;
                        }
                    }
                    break;
            }

            if (budjet >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {

                Console.WriteLine($"You don't have enough money! You need ${price - budjet:F2} more.");
            }
        }
    }
}
