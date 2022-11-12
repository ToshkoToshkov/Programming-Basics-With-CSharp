using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            for (int i = 1; i <= clients; i++)
            {
                string input = Console.ReadLine();
                double price = 0;
                double numPurchases = 0.0;


                while (input != "Finish")
                {
                    numPurchases++;
                    if (input == "basket")
                    {
                        price += 1.50;
                    }
                    if (input == "wreath")
                    {
                        price += 3.80;
                    }
                    if (input == "chocolate bunny")
                    {
                        price += 7.00;
                    }
                    input = Console.ReadLine();
                }

                if (numPurchases % 2 == 0)
                {
                    double discount = price * 0.20;
                    price -= discount;
                }

                Console.WriteLine($"You purchased {numPurchases} items for {price:F2} leva.");
                totalPrice += price;
            }

            Console.WriteLine($"Average bill per client is: {totalPrice / clients:F2} leva.");
        }
    }
}
