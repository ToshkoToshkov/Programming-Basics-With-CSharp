using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age and gender and name");
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (gender == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine($"Miss {name}");
                }
                else if (age >= 16)
                {
                    Console.WriteLine($"Ms. {name}");
                }
            }
            else if (gender == 'm')
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
