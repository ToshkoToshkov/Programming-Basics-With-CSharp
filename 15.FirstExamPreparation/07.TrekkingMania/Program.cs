using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGroups = int.Parse(Console.ReadLine());

            int numOfPeopleInTheGroup = 0;

            double totalNumberOfPeople = 0.0;

            double Musala = 0.0;
            double Monblan = 0.0;
            double Kilimandjaro = 0.0;
            double k2 = 0.0;
            double Everest = 0.0;

            for (int i = 1; i <= numOfGroups; i++)
            {
                numOfPeopleInTheGroup = int.Parse(Console.ReadLine());
                totalNumberOfPeople += numOfPeopleInTheGroup;
                if (numOfPeopleInTheGroup <= 5)
                {
                    Musala += numOfPeopleInTheGroup;
                }
                else if (numOfPeopleInTheGroup >= 6 && numOfPeopleInTheGroup <= 12)
                {
                    Monblan += numOfPeopleInTheGroup;
                }
                else if (numOfPeopleInTheGroup >= 13 && numOfPeopleInTheGroup <= 25)
                {
                    Kilimandjaro += numOfPeopleInTheGroup;
                }
                else if (numOfPeopleInTheGroup >= 26 && numOfPeopleInTheGroup <= 40)
                {
                    k2 += numOfPeopleInTheGroup;
                }
                else if (numOfPeopleInTheGroup >= 41)
                {
                    Everest += numOfPeopleInTheGroup;
                }
            }

            double percentMusala = Musala / totalNumberOfPeople * 100;
            double percentMonblan = Monblan / totalNumberOfPeople * 100;
            double percentKilimanjaro = Kilimandjaro / totalNumberOfPeople * 100;
            double percentK2 = k2 / totalNumberOfPeople * 100;
            double percentEverest = Everest / totalNumberOfPeople * 100;

            Console.WriteLine($"{percentMusala:F2}%");
            Console.WriteLine($"{percentMonblan:F2}%");
            Console.WriteLine($"{percentKilimanjaro:F2}%");
            Console.WriteLine($"{percentK2:F2}%");
            Console.WriteLine($"{percentEverest:F2}%");

        }
    }
}
