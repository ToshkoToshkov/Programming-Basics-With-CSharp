using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            int spendDays = 0;
            int days = 0;
            bool isManaged = true;

            while (budjet < neededMoney)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;

                if (action == "spend")
                {
                    spendDays++;

                    if (spendDays == 5)
                    {
                        isManaged = false;
                        break;
                    }

                    budjet -= money;

                    if (budjet < 0)
                    {
                        budjet = 0;
                    }
                }
                else if (action == "save")
                {
                    spendDays = 0;
                    budjet += money;
                }
            }
            if (isManaged)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
