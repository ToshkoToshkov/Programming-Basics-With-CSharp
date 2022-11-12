using System;
using System.Runtime.Serialization;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0.0;
            double succesScholarship = 0.0;
            double studyScholarship = 0.0;

            string output = "";

            if (averageGrade >= 5.50)
            {
                succesScholarship = averageGrade * 25;
                studyScholarship = succesScholarship;
            }

            if (averageGrade >= 4.50)
            {
                if (income < minSalary)
                {
                    socialScholarship = minSalary * 0.35;
                    studyScholarship = socialScholarship;
                }
            }

            if (socialScholarship > succesScholarship)
            {
                output = $"You get a Social scholarship {Math.Floor(socialScholarship)} BGN";
            }

            else if (socialScholarship <= succesScholarship)
            {
                output = $"You get a scholarship for excellent results {Math.Floor(succesScholarship)} BGN";
            }

            if (studyScholarship == 0)
            {
                output = "You cannot get a scholarship!";
            }

            Console.WriteLine(output);
        }
    }
}
