using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double LP1 = p1 * h;
            double LP2 = p2 * h;
            double fullPool = LP1 + LP2;

            if (fullPool <= v)
            {

                double percentVolume = fullPool / v * 100;
                double firstPipe = LP1 / fullPool * 100;
                double secondPipe = LP2 / fullPool * 100;
                Console.WriteLine("The pool is " + $"{percentVolume:F2}" + "% full. Pipe 1: " + $"{firstPipe:F2}" + "%. Pipe 2: " + $"{secondPipe:F2}" + "%.");
            }
            else if (fullPool > v)
            {
                double litersMore = fullPool - v;

                Console.WriteLine("For " + h + " hours the pool overflows with " + $"{litersMore:F2}" + " liters.");
            }
        }
    }
}
