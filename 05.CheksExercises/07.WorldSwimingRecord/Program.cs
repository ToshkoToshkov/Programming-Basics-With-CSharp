using System;

namespace WorldSwimingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recInSec = double.Parse(Console.ReadLine());
            double distanceInMetters = double.Parse(Console.ReadLine());
            double timeInSecPerOneMetter = double.Parse(Console.ReadLine());

            double distance = distanceInMetters * timeInSecPerOneMetter;
            double delay = Math.Floor(distanceInMetters / 15) * 12.5;
            double totalTime = distance + delay;

            if (totalTime < recInSec)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is " + $"{totalTime:F2}" + " seconds.");

            }
            else
            {
                double secSlower = totalTime - recInSec;
                Console.WriteLine("No, he failed! He was " + $"{secSlower:F2}" + " seconds slower.");
            }
        }
    }
}
