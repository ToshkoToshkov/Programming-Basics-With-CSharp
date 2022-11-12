using System;
using System.Globalization;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEggsFirstPlayer = int.Parse(Console.ReadLine());
            int numEggsSecondPlayer = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    numEggsSecondPlayer--;
                    if (numEggsSecondPlayer <= 0)
                    {
                        break;
                    }
                }
                else if (winner == "two")
                {
                    numEggsFirstPlayer--;
                    if (numEggsFirstPlayer <= 0)
                    {
                        break;
                    }
                }
                winner = Console.ReadLine();
            }

            if (winner == "End of battle")
            {
                Console.WriteLine($"Player one has {numEggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {numEggsSecondPlayer} eggs left.");
            }

            if (numEggsFirstPlayer <= 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {numEggsSecondPlayer} eggs left.");
            }
            else if (numEggsSecondPlayer <= 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {numEggsFirstPlayer} eggs left.");
            }
        }
    }
}
