using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEasterBreads = int.Parse(Console.ReadLine());

            double maxPoints = 0.0;
            string theBest = "";

            for (int i = 1; i <= numOfEasterBreads; i++)
            {
                string name = Console.ReadLine();
                int points = 0;
                string grade = Console.ReadLine();

                while (grade != "Stop")
                {
                    points += int.Parse(grade);
                    grade = Console.ReadLine();
                }

                Console.WriteLine($"{name} has {points} points.");

                if (points > maxPoints)
                {
                    theBest = name;
                    maxPoints = points;
                    Console.WriteLine($"{name} is the new number 1!");
                }
            }
            Console.WriteLine($"{theBest} won competition with {maxPoints} points!");
        }
    }
}
