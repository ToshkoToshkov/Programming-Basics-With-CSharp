using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte studentTicket = 0;
            byte standartTicket = 0;
            byte kidTicket = 0;

            string movie = Console.ReadLine();

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                byte currentMovieTickets = 0;

                for (int i = 0; i < availableSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicket++;
                    }
                    else if (ticketType == "standart")
                    {
                        standartTicket++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicket++;
                    }

                    currentMovieTickets++;
                }

                Console.WriteLine($"{movie} - {(double)currentMovieTickets / availableSeats * 100:F2}% full.");

                movie = Console.ReadLine();
            }

            int totalTickets = studentTicket + standartTicket + kidTicket;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTicket / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standartTicket / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTicket / totalTickets * 100:f2}% kids tickets.");
        }
    }
}