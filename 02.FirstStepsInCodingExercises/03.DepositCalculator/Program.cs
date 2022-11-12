using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double interestForMonth = initialSum * (percent * 0.01) / 12;
            double result = initialSum + months * interestForMonth;

            Console.WriteLine(result);
        }
    }
}