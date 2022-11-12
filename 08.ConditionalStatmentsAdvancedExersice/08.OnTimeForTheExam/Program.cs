using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arrivalTime = arrivalHour * 60 + arrivalMinutes;

            if (arrivalTime < examTime - 30)
            {
                double timeEarly = examTime - arrivalTime;
                if (timeEarly < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", timeEarly);
                }
                else if (timeEarly >= 60)
                {
                    var hoursEarly = timeEarly / 60;
                    var minutesEarly = timeEarly % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", hoursEarly, minutesEarly);
                }
            }
            else if (arrivalTime <= examTime && arrivalTime <= examTime - 30)
            {
                double timeOnTime = examTime - arrivalTime;
                Console.WriteLine("On time");
                Console.WriteLine("{0} : minutes before the start", timeOnTime);
            }
            if (arrivalTime > examTime)
            {
                double timeLate = arrivalTime - examTime;
                if (timeLate < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", timeLate);
                }
                else if (timeLate >= 60)
                {
                    double hoursLate = timeLate / 60;
                    double minLate = timeLate % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} {1:00} hours after the start", hoursLate, minLate);
                }

            }




        }
    }
}
