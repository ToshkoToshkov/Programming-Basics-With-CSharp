using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double areaSideWall = x * y;
            double areaWindow = 1.5 * 1.5;
            double totalSideWall = 2 * areaSideWall - 2 * areaWindow;

            double areaBackWall = x * x;
            double areaDoor = 1.2 * 2;
            double totalAreaFrontAndBackWall = 2 * areaBackWall - areaDoor;

            double totalAreaWalls = totalAreaFrontAndBackWall + totalSideWall;
            double littersGreenPaint = totalAreaWalls / 3.4;

            double areaSideRoof = 2 * (x * y);
            double areaTriangle = 2 * (x * h / 2);
            double totalAreaRoof = areaSideRoof + areaTriangle;
            double littersRedPaint = totalAreaRoof / 4.3;

            Console.WriteLine($"{littersGreenPaint:F2}");
            Console.WriteLine($"{littersRedPaint:F2}");
        }
    }
}
