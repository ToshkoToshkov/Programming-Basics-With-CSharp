using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gr = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            switch (timeOfDay)
            {
                case "Morning":
                    if (gr >= 10 && gr <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (gr > 18 && gr <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gr >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }

                    Console.WriteLine("It's " + gr + " degrees, get your " + outfit + " and " + shoes + ".");
                    break;

                case "Afternoon":
                    if (gr >= 10 && gr <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gr > 18 && gr <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (gr >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }

                    Console.WriteLine("It's " + gr + " degrees, get your " + outfit + " and " + shoes + ".");
                    break;

                case "Evening":
                    if (gr >= 10 && gr <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gr > 18 && gr <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gr >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }

                    Console.WriteLine("It's " + gr + " degrees, get your " + outfit + " and " + shoes + ".");
                    break;
            }
        }
    }
}
