using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArchitect = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());

            double timeForAllProjects = numOfProjects * 3;

            Console.WriteLine("The architect " + nameArchitect + " will need " + timeForAllProjects + " hours to complete " + numOfProjects + " project/s.");
        }
    }
}