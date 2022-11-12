using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = side * hight / 2;

            Console.WriteLine($"{area:F2}");
        }
    }
}