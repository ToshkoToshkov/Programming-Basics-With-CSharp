﻿using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num < evenMin)
                    {
                        evenMin = num;

                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }

            Console.WriteLine("OddSum=" + $"{oddSum:F2}" + ",");

            if (oddSum == 0)
            {
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("OddMin=No,");
            }
            else
            {

                Console.WriteLine("OddMin=" + $"{oddMin:F2}" + ",");
                Console.WriteLine("OddMax=" + $"{oddMax:F2}" + ",");
            }

            Console.WriteLine("EvenSum=" + $"{evenSum:F2}" + ",");

            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + $"{evenMin:F2}" + ",");
                Console.WriteLine("EvenMax=" + $"{evenMax:F2}");
            }
        }
    }
}
