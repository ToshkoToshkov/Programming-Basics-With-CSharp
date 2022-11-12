using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine());
            double priceSprinkle = double.Parse(Console.ReadLine());
            double kgBonito = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgClams = int.Parse(Console.ReadLine());

            double priceBonito = priceMackerel + priceMackerel * 0.60;
            double priceSafrid = priceSprinkle + priceSprinkle * 0.80;

            double totalPriceBonito = kgBonito * priceBonito;
            double totalPriceSafrid = kgSafrid * priceSafrid;
            double totalPriceClams = kgClams * 7.50;

            double moneyToPay = totalPriceClams + totalPriceBonito + totalPriceSafrid;

            Console.WriteLine($"{moneyToPay:F2}");

        }
    }
}