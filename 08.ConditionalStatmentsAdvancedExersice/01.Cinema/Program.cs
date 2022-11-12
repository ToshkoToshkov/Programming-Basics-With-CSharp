using System;
using System.Runtime.Serialization;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = rows * column * 12;
            }
            else if (type == "Normal")
            {
                income = rows * column * 7.50;
            }
            else if (type == "Discount")
            {
                income = rows * column * 5;
            }

            Console.WriteLine($"{income:F2}" + " leva");
        }
    }
}