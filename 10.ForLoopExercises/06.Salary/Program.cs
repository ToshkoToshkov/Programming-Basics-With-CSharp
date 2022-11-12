using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string nameWebsite = "";
            int left = 0;


            for (int i = 1; i <= openTabs; i++)
            {
                nameWebsite = Console.ReadLine();

                if (nameWebsite == "Facebook")
                {
                    salary -= 150;
                }
                else if (nameWebsite == "Instagram")
                {
                    salary -= 100;
                }
                else if (nameWebsite == "Reddit")
                {
                    salary -= 50;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
