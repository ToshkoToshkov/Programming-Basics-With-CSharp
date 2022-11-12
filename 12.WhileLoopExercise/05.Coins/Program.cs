using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double rest = double.Parse(Console.ReadLine());

            double coins = rest / 0.01;

            double moneta2Lv = 200;
            double moneta1Lv = 100;
            double moneta50Cnt = 50;
            double moneta20Cnt = 20;
            double moneta10Cnt = 10;
            double moneta5Cnt = 5;
            double moneta2Cnt = 2;
            double moneta1Cnt = 1;
            int numOfCoins = 0;


            while (coins >= moneta2Lv)
            {
                coins -= moneta2Lv;
                numOfCoins++;
            }

            while (coins >= moneta1Lv)
            {
                coins -= moneta1Lv;
                numOfCoins++;
            }

            while (coins >= moneta50Cnt)
            {
                coins -= moneta50Cnt;
                numOfCoins++;
            }

            while (coins >= moneta20Cnt)
            {
                coins -= moneta20Cnt;
                numOfCoins++;
            }

            while (coins >= moneta10Cnt)
            {
                coins -= moneta10Cnt;
                numOfCoins++;
            }

            while (coins >= moneta5Cnt)
            {
                coins -= moneta5Cnt;
                numOfCoins++;
            }

            while (coins >= moneta2Cnt)
            {
                coins -= moneta2Cnt;
                numOfCoins++;
            }

            while (coins >= moneta1Cnt)
            {
                coins -= moneta1Cnt;
                numOfCoins++;
            }

            Console.WriteLine(numOfCoins);
        }
    }
}
