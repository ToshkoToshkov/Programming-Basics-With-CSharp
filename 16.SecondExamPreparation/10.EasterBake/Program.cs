using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEasterBreads = int.Parse(Console.ReadLine());

            double totalSugar = 0;
            double totalFlour = 0;

            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            for (int i = 1; i <= numOfEasterBreads; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                totalSugar += sugar;
                totalFlour += flour;

                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }

                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }
            }

            double numPacketsOfSugar = totalSugar / 950;
            double numPacketsOfFlour = totalFlour / 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(numPacketsOfSugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(numPacketsOfFlour)}");

            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
