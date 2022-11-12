using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double amountOfFoodForDog = 0.0;
            double eatedFoodForDog = 0.0;

            double amountOfFoodForCat = 0.0;
            double eatedFoodForCat = 0.0;

            double cookies = 0.0;

            for (int i = 1; i <= days; i++)
            {
                amountOfFoodForDog = double.Parse(Console.ReadLine());
                amountOfFoodForCat = double.Parse(Console.ReadLine());
                double totalFoodForDay = amountOfFoodForCat + amountOfFoodForDog;
                eatedFoodForDog += amountOfFoodForDog;
                eatedFoodForCat += amountOfFoodForCat;

                if (i % 3 == 0)
                {

                    cookies += totalFoodForDay * 0.1;
                }

            }

            double totalOfEatedFood = eatedFoodForDog + eatedFoodForCat;
            double percentOfEatedFood = totalOfEatedFood * 100 / totalFood;
            double percentEatedFoodForDog = eatedFoodForDog * 100 / totalOfEatedFood;
            double percentEatedFoodForCat = eatedFoodForCat * 100 / totalOfEatedFood;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            Console.WriteLine($"{percentOfEatedFood:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatedFoodForDog:F2}% eaten from the dog.");
            Console.WriteLine($"{percentEatedFoodForCat:F2}% eaten from the cat.");
        }
    }
}
