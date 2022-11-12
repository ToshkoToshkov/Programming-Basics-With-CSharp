using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordinSec = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());

            double totalTime = meters * secPerMeter;

            double slow = Math.Floor(meters / 50) * 30;

            double total = totalTime + slow;

            if (total < recordinSec)
            {
                Console.WriteLine($"Yes! The new record is {total:F2} seconds.");
            }
            else
            {
                double difference = total - recordinSec;
                Console.WriteLine($"No! He was {difference:F2} seconds slower.");
            }
        }
    }
}
