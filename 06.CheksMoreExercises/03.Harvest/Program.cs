using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());

            double harvest = x * y;
            double harvestForWine = harvest * 0.4;
            double producedWine = harvestForWine / 2.5;

            if (producedWine > z)
            {
                double wineLeft = producedWine - z;
                double litersWineForWorkers = wineLeft / numOfWorkers;

                Console.WriteLine("Good harvest this year! Total wine: " + Math.Floor(producedWine) + " liters.");
                Console.WriteLine(Math.Ceiling(wineLeft) + " liters left -> " + Math.Ceiling(litersWineForWorkers) + " liters per person.");
            }
            else if (producedWine <= z)
            {
                double notEnough = z - producedWine;

                Console.WriteLine("It will be a tough winter! More " + Math.Floor(notEnough) + " liters wine needed.");
            }
        }
    }
}
