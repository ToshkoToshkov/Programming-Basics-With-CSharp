using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfFood = int.Parse(Console.ReadLine());
            string gramsEatenAtEachMeal = Console.ReadLine();

            int amountOfFoodInGrams = amountOfFood * 1000;

            double amountOfFoodUntilAdoption = 0.0;

            while (gramsEatenAtEachMeal != "Adopted")
            {
                double gramsEatenAt1Meal = double.Parse(gramsEatenAtEachMeal);
                amountOfFoodUntilAdoption += gramsEatenAt1Meal;


                gramsEatenAtEachMeal = Console.ReadLine();
            }

            if (amountOfFoodInGrams >= amountOfFoodUntilAdoption)
            {
                double restedFood = amountOfFoodInGrams - amountOfFoodUntilAdoption;
                Console.WriteLine($"Food is enough! Leftovers: {restedFood} grams.");
            }
            else
            {
                double neededFood = amountOfFoodUntilAdoption - amountOfFoodInGrams;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }

        }
    }
}
