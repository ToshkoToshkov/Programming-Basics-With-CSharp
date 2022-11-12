using System;
using System.Transactions;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            double hCm = h * 100;
            double wCm = w * 100 - 100;
            double chekH = hCm / 120;
            double chekH2 = Math.Floor(chekH);
            double chekW = wCm / 70;
            double chekW2 = Math.Floor(chekW);
            double totalDesks = chekW2 * chekH2 - 3;

            Console.WriteLine(totalDesks);
        }
    }
}