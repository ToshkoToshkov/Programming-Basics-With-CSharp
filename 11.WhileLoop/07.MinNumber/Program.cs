using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int nums = 0;
            int minNum = int.MaxValue;

            while (input != "Stop")
            {
                nums = int.Parse(input);

                if (nums < minNum)
                {
                    minNum = nums;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
