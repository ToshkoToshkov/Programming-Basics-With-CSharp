using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKilVeget = double.Parse(Console.ReadLine());
            double pricePerKilFruits = double.Parse(Console.ReadLine());
            int kgVeget = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            double totalPriceVeget = pricePerKilVeget * kgVeget;
            double totalPriceFruits = pricePerKilFruits * kgFruits;

            double totalPriceInLv = totalPriceFruits + totalPriceVeget;

            double totalPriceInEuro = totalPriceInLv / 1.94;

            Console.WriteLine($"{totalPriceInEuro:F2}");
        }
    }
}