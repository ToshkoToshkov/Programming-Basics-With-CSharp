using System;

namespace TimePlus15MIn
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());

            min += 15;

            if (min >= 60)
            {
                min = min - 60;
                hour = hour + 1;
            }

            if (hour >= 24)
            {
                hour = 0;
            }

            string output = "";

            if (min < 10)
            {
                output = $"{hour}:0{min}";
            }
            else
            {
                output = $"{hour}:{min}";
            }

            Console.WriteLine(output);
        }
    }
}
