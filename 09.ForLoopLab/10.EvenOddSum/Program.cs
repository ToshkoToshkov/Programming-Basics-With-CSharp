using System;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nums = 0;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                nums = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += nums;
                }
                else
                {
                    sumOdd += nums;
                }

            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
