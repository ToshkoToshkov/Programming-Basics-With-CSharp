using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string result = Console.ReadLine();

            if (input == "cm")
            {
                num /= 100;
            }
            if (input == "mm")
            {
                num /= 1000;
            }

            if (result == "cm")
            {
                num = num * 100;
            }
            else if (result == "mm")
            {
                num = num * 1000;
            }

            Console.WriteLine($"{num:F3}");
        }
    }
}