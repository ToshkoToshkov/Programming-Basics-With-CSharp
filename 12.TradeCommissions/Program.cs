using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double comission = 0.0;

            switch (city)
            {
                case "Sofia":
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = sells * 0.05;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = sells * 0.07;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = sells * 0.08;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 10000)
                    {
                        comission = sells * 0.12;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = sells * (4.5 / 100);
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = sells * (7.5 / 100);
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = sells * 0.1;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 10000)
                    {
                        comission = sells * 0.13;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = sells * (5.5 / 100);
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = sells * 0.08;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = sells * 0.12;
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells > 10000)
                    {
                        comission = sells * (14.5 / 100);
                        Console.WriteLine($"{comission:F2}");
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
