using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTheDays = int.Parse(Console.ReadLine());
            int numOfconfectioners = int.Parse(Console.ReadLine());

            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfwaffles = int.Parse(Console.ReadLine());
            int numOfCreps = int.Parse(Console.ReadLine());

            double priceOfCake = 45;
            double priceOfWaffle = 5.80;
            double priceOfCrep = 3.20;

            double cakesPrice = numOfCakes * priceOfCake;
            double wafflesPrice = numOfwaffles * priceOfWaffle;
            double crepsPrice = numOfCreps * priceOfCrep;

            double moneyPerDay = (cakesPrice + wafflesPrice + crepsPrice) * numOfconfectioners;
            double recruitedMoneyOfCampaign = moneyPerDay * numOfTheDays;

            double expences = recruitedMoneyOfCampaign / 8;
            double moneyAfterExpences = recruitedMoneyOfCampaign - expences;

            Console.WriteLine($"{moneyAfterExpences:F2}");
        }
    }
}