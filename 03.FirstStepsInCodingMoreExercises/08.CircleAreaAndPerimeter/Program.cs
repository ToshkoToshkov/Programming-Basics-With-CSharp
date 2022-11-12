using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double areaCircle = Math.PI * (r * r);

            double perimeterCircle = 2 * Math.PI * r;

            Console.WriteLine($"{areaCircle:F2}");
            Console.WriteLine($"{perimeterCircle:F2}");
        }
    }
}
