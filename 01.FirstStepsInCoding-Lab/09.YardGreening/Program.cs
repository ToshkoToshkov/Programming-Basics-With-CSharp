using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double mettersForGreening = double.Parse(Console.ReadLine());

            double totalPriceForGreening = mettersForGreening * 7.61;
            double theDiscount = 0.18 * totalPriceForGreening;
            double finalPrice = totalPriceForGreening - theDiscount;

            Console.WriteLine("The final price is: " + finalPrice + " lv.");
            Console.WriteLine("The discount is: " + theDiscount + " lv.");

        }
    }
}