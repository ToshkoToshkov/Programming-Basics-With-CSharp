using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfKgFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int numOFEggshels = int.Parse(Console.ReadLine());
            int packetOfYeast = int.Parse(Console.ReadLine());

            double priceFlour = priceOfKgFlour * kgFlour;

            double priceKgSugar = priceOfKgFlour - (priceOfKgFlour * 0.25);
            double priceSugar = kgSugar * priceKgSugar;

            double priceEggshell = priceOfKgFlour + (priceOfKgFlour * 0.1);
            double priceOFEggs = priceEggshell * numOFEggshels;

            double pricePacketOfYeast = priceKgSugar - (priceKgSugar * 0.8);
            double priceYeast = pricePacketOfYeast * packetOfYeast;

            double totalPrice = priceFlour + priceSugar + priceOFEggs + priceYeast;

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
