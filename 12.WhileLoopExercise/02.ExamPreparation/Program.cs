using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradesLimit = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();

            bool isExcelent = true;
            int poorGrades = 0;
            double score = 0;
            int allGrades = 0;
            string lastProblem = "";

            while (task != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());

                score += grade;
                allGrades++;
                lastProblem = task;

                if (grade <= 4)
                {
                    poorGrades++;
                    if (poorGrades == poorGradesLimit)
                    {
                        isExcelent = false;
                        break;
                    }
                }

                task = Console.ReadLine();
            }

            double averageGrade = score / allGrades;

            if (isExcelent)
            {
                Console.WriteLine($"Average score: {averageGrade:F2}");
                Console.WriteLine($"Number of problems: {allGrades}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
        }
    }
}
