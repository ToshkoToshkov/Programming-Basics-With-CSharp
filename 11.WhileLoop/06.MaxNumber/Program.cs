using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int nums = 0;
            int maxNum = int.MinValue;

            while (input != "Stop")
            {
                nums = int.Parse(input);
                if (nums > maxNum)
                {
                    maxNum = nums;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(maxNum);
        }
    }
}
