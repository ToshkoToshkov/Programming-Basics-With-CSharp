using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int Eggs = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int numEggs = int.Parse(Console.ReadLine());

            int sellEggs = 0;

            while (action != "Close")
            {
                if (action == "Buy")
                {
                    if (numEggs > Eggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {Eggs}.");
                        break;
                    }

                    Eggs -= numEggs;
                    sellEggs += numEggs;
                }
                else if (action == "Fill")
                {
                    Eggs += numEggs;
                }


                action = Console.ReadLine();

                if (action == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{sellEggs} eggs sold.");
                    break;
                }

                numEggs = int.Parse(Console.ReadLine());
            }
        }
    }
}
