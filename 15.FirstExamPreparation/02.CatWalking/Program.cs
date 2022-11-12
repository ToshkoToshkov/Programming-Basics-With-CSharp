using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minWalk = int.Parse(Console.ReadLine());
            int numWalk = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            double totalMinPerDay = minWalk * numWalk;
            double calories = totalMinPerDay * 5;
            double percent = caloriesPerDay / 2;

            if (calories >= percent)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {calories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {calories}.");
            }


        }
    }
}
