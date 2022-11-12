using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEasterBreads = int.Parse(Console.ReadLine());
            int numberOfEggshels = int.Parse(Console.ReadLine());
            int numberOfCookies = int.Parse(Console.ReadLine());

            double priceOfEasterBread = numOfEasterBreads * 3.20;
            double priceEggs = numberOfEggshels * 4.35;
            double priceOfCookies = numberOfCookies * 5.40;
            double numOfEggs = numberOfEggshels * 12;
            double pricePaint = numOfEggs * 0.15;

            double totalPrice = priceOfEasterBread + priceEggs + priceOfCookies + pricePaint;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
