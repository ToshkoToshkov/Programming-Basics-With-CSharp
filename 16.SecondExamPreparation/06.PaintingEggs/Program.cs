using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int numsells = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (color)
            {
                case "Red":
                    if (size == "Large")
                    {
                        price = 16;
                    }
                    else if (size == "Medium")
                    {
                        price = 13;
                    }
                    else if (size == "Small")
                    {
                        price = 9;
                    }
                    break;

                case "Green":
                    if (size == "Large")
                    {
                        price = 12;
                    }
                    else if (size == "Medium")
                    {
                        price = 9;
                    }
                    else if (size == "Small")
                    {
                        price = 8;
                    }
                    break;

                case "Yellow":
                    if (size == "Large")
                    {
                        price = 9;
                    }
                    else if (size == "Medium")
                    {
                        price = 7;
                    }
                    else if (size == "Small")
                    {
                        price = 5;
                    }
                    break;
            }

            double totalPrice = price * numsells;
            double outcomes = totalPrice * 0.35;
            double finalPrice = totalPrice - outcomes;

            Console.WriteLine($"{finalPrice:F2} leva.");
        }
    }
}
