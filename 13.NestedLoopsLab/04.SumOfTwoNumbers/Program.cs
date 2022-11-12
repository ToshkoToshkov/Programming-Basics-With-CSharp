using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int numCombination = 0;
            bool isTrue = false;

            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    numCombination++;

                    if (i + j == magicNum)
                    {
                        isTrue = true;
                        Console.WriteLine($"Combination N:{numCombination} ({i} + {j} = {magicNum})");
                        break;
                    }
                }

                if (isTrue)
                {
                    break;
                }
            }

            if (!isTrue)
            {
                Console.WriteLine($"{numCombination} combinations - neither equals {magicNum}");
            }
        }
    }
}
