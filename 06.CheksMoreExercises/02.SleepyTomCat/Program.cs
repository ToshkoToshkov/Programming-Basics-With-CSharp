using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfHolidays = int.Parse(Console.ReadLine());

            int numOfWorkingDays = 365 - numOfHolidays;

            double playtimeOnWeekends = numOfHolidays * 127;
            double playtimeOnWorkingDays = numOfWorkingDays * 63;

            double totalPlaytimePerYear = playtimeOnWeekends + playtimeOnWorkingDays;
            double difference = Math.Abs(30000 - totalPlaytimePerYear);
            double differenceInHours = difference / 60;
            double differenceInMinutes = difference % 60;

            if (totalPlaytimePerYear <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine(Math.Floor(differenceInHours) + " hours and " + Math.Round(differenceInMinutes) + " minutes less for play");
            }
            else if (totalPlaytimePerYear > 30000)
            {
                double diff = Math.Abs(totalPlaytimePerYear - 30000);
                double diffInHours = diff / 60;
                double diffInMinutes = diff % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine(Math.Floor(diffInHours) + " hours and " + Math.Round(diffInMinutes) + " minutes more for play");
            }
        }
    }
}
