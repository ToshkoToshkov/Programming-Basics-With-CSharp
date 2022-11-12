using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0.0;
            string place = "";
            String country = "";

            if (budjet <= 100)
            {
                country = "Bulgaria";

                if (season == "summer")
                {
                    price = budjet * 0.30;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    price = budjet * 0.70;
                    place = "Hotel";
                }
            }
            else if (budjet <= 1000)
            {
                country = "Balkans";

                if (season == "summer")
                {
                    price = budjet * 0.40;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    price = budjet * 0.80;
                    place = "Hotel";
                }

            }
            else if (budjet > 1000)
            {
                country = "Europe";
                price = budjet * 0.90;
                place = "Hotel";
            }

            Console.WriteLine("Somewhere in " + country);
            Console.WriteLine(place + " - " + ($"{price:F2}"));
        }
    }
}
