using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double currentINcrease = 0.0;
            double bankAccount = 0.0;

            while (input != "NoMoreMoney")
            {
                currentINcrease = double.Parse(input);

                if (currentINcrease < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                bankAccount += currentINcrease;

                Console.WriteLine($"Increase: {currentINcrease:F2}");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {bankAccount:F2}");
        }
    }
}