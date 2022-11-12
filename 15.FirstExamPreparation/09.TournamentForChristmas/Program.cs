using System;

namespace TournamentForChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double moneyRaisedDaily = 0.0;
            int lostGamesCount = 0;
            int wonGamesCount = 0;
            int daysWinning = 0;
            int daysLost = 0;
            double totalMoneyRaised = 0;

            for (int day = 1; day <= days; day++)
            {
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        moneyRaisedDaily += 20;
                        wonGamesCount++;
                    }
                    else
                    {
                        lostGamesCount++;
                    }
                    input = Console.ReadLine();
                }

                if (wonGamesCount > lostGamesCount)
                {
                    moneyRaisedDaily += moneyRaisedDaily * 0.1;
                    daysWinning++;
                }
                else
                {
                    daysLost++;
                }

                wonGamesCount = 0;
                lostGamesCount = 0;
                totalMoneyRaised += moneyRaisedDaily;
                moneyRaisedDaily = 0;
            }

            if (daysWinning > daysLost)
            {
                totalMoneyRaised += totalMoneyRaised * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyRaised:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyRaised:f2}");
            }
        }
    }
}
