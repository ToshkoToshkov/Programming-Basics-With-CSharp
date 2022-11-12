using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGuests = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double numOfEasterBreads = Math.Ceiling(numOfGuests * 1.0 / 3);
            double numOfEggs = numOfGuests * 2;

            double priceOfEasterBread = numOfEasterBreads * 4;
            double priceOfEggs = numOfEggs * 0.45;

            double totalPrice = priceOfEasterBread + priceOfEggs;

            if (budjet >= totalPrice)
            {
                double difference = budjet - totalPrice;
                Console.WriteLine($"Lyubo bought {numOfEasterBreads} Easter bread and {numOfEggs} eggs.");
                Console.WriteLine($"He has {difference:F2} lv. left.");
            }
            else
            {
                double difference = totalPrice - budjet;
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {difference:F2} lv. more.");
            }
        }
    }
}