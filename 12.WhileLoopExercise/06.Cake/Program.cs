using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int piecesCake = lenght * width;
            string line = Console.ReadLine();
            bool isCakeEnough = true;

            while (line != "STOP")
            {
                int currentPieces = int.Parse(line);
                piecesCake -= currentPieces;
                if (piecesCake < 0)
                {
                    isCakeEnough = false;
                    break;
                }

                line = Console.ReadLine();
            }

            if (isCakeEnough)
            {
                Console.WriteLine($"{piecesCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCake)} pieces more.");
            }
        }
    }
}
