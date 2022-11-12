using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBitcoins = int.Parse(Console.ReadLine());
            double numYuans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoinInLv = numBitcoins * 1168;
            double yoanInDOlars = numYuans * 0.15;
            double dolarsInLv = yoanInDOlars * 1.76;
            double totalLv = bitcoinInLv + dolarsInLv;
            double totalEuro = totalLv / 1.95;
            double totalMoney = totalEuro - (totalEuro * commision / 100);
            Console.WriteLine($"{totalMoney:F2}");
        }
    }
}