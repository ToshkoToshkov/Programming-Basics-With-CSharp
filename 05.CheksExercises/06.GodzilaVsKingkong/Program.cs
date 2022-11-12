using System;

namespace GodzilaVsKingkong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfExtras = int.Parse(Console.ReadLine());
            double priceClothingForExtra = double.Parse(Console.ReadLine());

            double priceDecor = budget * 0.1;


            if (numOfExtras > 150)
            {
                priceClothingForExtra = priceClothingForExtra - (priceClothingForExtra * 0.1);
            }
            else
            {
                priceClothingForExtra = priceClothingForExtra;
            }

            double totalPriceExtras = numOfExtras * priceClothingForExtra;

            double expencesForDecorAndClothing = priceDecor + totalPriceExtras;

            if (expencesForDecorAndClothing > budget)
            {
                double neededMoney = expencesForDecorAndClothing - budget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs " + $"{neededMoney:F2}" + " leva more.");

            }
            else
            {
                double moneyLeft = budget - expencesForDecorAndClothing;
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with " + $"{moneyLeft:F2}" + " leva left.");

            }
        }
    }
}
