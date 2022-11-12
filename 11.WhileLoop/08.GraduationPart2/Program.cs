using System;

namespace GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int countGrade = 0;
            double grade = 0;
            double average = 0;
            double lowGrade = 0;
            bool isExcluded = false;

            while (countGrade < 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    countGrade++;
                    average += grade;
                }
                else if (grade < 4)
                {
                    lowGrade++;

                    if (lowGrade == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {countGrade} grade");
                        isExcluded = true;
                        break;
                    }

                    countGrade++;
                }
            }

            if (isExcluded == false)
            {
                average /= 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
