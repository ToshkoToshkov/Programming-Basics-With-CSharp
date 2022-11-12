using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishermans = int.Parse(Console.ReadLine());

            double price = 0.0;
            double discount = 0.0;
            double doubleDiscount = 0.0;


            switch (season)
            {
                case "Spring":

                    if (numFishermans <= 6)
                    {
                        discount = 3000 * 0.1;
                        price = 3000 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }

                    }
                    else if (numFishermans > 7 && numFishermans <= 11)
                    {
                        discount = 3000 * 0.15;
                        price = 3000 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }

                    }
                    else if (numFishermans > 12)
                    {
                        discount = 3000 * 0.25;
                        price = 3000 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }
                    }

                    if (budjet >= price)
                    {
                        double levaLeft = budjet - price;
                        Console.WriteLine("Yes! You have " + ($"{levaLeft:F2}") + " leva left.");
                    }
                    else if (budjet < price)
                    {
                        double moneyLeft = price - budjet;
                        Console.WriteLine("Not enough money! You need " + ($"{moneyLeft:F2}") + " leva.");
                    }

                    break;

                case "Summer":

                    if (numFishermans <= 6)
                    {
                        discount = 4200 * 0.1;
                        price = 4200 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }

                    }
                    else if (numFishermans > 7 && numFishermans <= 11)
                    {
                        discount = 4200 * 0.15;
                        price = 4200 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }

                    }
                    else if (numFishermans > 12)
                    {
                        discount = 4200 * 0.25;
                        price = 4200 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }
                    }

                    if (budjet >= price)
                    {
                        double levaLeft = budjet - price;
                        Console.WriteLine("Yes! You have " + ($"{levaLeft:F2}") + " leva left.");
                    }
                    else if (budjet < price)
                    {
                        double moneyLeft = price - budjet;
                        Console.WriteLine("Not enough money! You need " + ($"{moneyLeft:F2}") + " leva.");
                    }

                    break;

                case "Autumn":

                    if (numFishermans <= 6)
                    {
                        discount = 4200 * 0.1;
                        price = 4200 - discount;

                    }
                    else if (numFishermans > 7 && numFishermans <= 11)
                    {
                        discount = 4200 * 0.15;
                        price = 4200 - discount;
                    }
                    else if (numFishermans > 12)
                    {
                        discount = 4200 * 0.25;
                        price = 4200 - discount;
                    }

                    if (budjet >= price)
                    {
                        double levaLeft = budjet - price;
                        Console.WriteLine("Yes! You have " + ($"{levaLeft:F2}") + " leva left.");
                    }
                    else if (budjet < price)
                    {
                        double moneyLeft = price - budjet;
                        Console.WriteLine("Not enough money! You need " + ($"{moneyLeft:F2}") + " leva.");
                    }

                    break;

                case "Winter":

                    if (numFishermans <= 6)
                    {
                        discount = 2600 * 0.1;
                        price = 2600 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }

                    }
                    else if (numFishermans > 7 && numFishermans <= 11)
                    {
                        discount = 2600 * 0.15;
                        price = 2600 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }

                    }
                    else if (numFishermans > 12)
                    {
                        discount = 2600 * 0.25;
                        price = 2600 - discount;

                        if (numFishermans % 2 == 0)
                        {
                            doubleDiscount = price * 0.05;
                            price = price - doubleDiscount;
                        }
                    }

                    if (budjet >= price)
                    {
                        double levaLeft = budjet - price;
                        Console.WriteLine("Yes! You have " + ($"{levaLeft:F2}") + " leva left.");
                    }
                    else if (budjet < price)
                    {
                        double moneyLeft = price - budjet;
                        Console.WriteLine("Not enough money! You need " + ($"{moneyLeft:F2}") + " leva.");
                    }

                    break;
            }
        }
    }
}
