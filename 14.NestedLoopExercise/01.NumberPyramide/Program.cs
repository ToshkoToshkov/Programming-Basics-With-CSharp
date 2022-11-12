using System;

namespace NumberPyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            bool isBigger = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    if (count > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(count + " ");
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
