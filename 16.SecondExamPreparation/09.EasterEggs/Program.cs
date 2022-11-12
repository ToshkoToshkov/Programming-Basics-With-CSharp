using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPaintedEggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            int maxEggsCount = int.MinValue;
            string maxColor = "";

            for (int i = 1; i <= numOfPaintedEggs; i++)
            {
                string cvqt = Console.ReadLine();


                if (cvqt == "red")
                {
                    red++;
                }
                if (cvqt == "orange")
                {
                    orange++;
                }
                if (cvqt == "blue")
                {
                    blue++;
                }
                if (cvqt == "green")
                {
                    green++;
                }
            }

            if (red >= maxEggsCount)
            {
                maxEggsCount = red;
                maxColor = "red";
            }
            if (orange >= maxEggsCount)
            {
                maxEggsCount = orange;
                maxColor = "orange";
            }
            if (blue >= maxEggsCount)
            {
                maxEggsCount = blue;
                maxColor = "blue";
            }
            if (green >= maxEggsCount)
            {
                maxEggsCount = green;
                maxColor = "green";
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxEggsCount} -> {maxColor}");
        }
    }
}
