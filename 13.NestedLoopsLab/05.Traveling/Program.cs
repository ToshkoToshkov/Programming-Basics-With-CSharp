using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double cost = double.Parse(Console.ReadLine());
                double earnedSaving = 0;

                while (cost > earnedSaving)
                {
                    earnedSaving += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
