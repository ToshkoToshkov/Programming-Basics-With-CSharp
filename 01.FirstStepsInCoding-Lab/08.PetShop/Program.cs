using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDogs = int.Parse(Console.ReadLine());
            int numOfOtherAnimals = int.Parse(Console.ReadLine());

            double priceFoodForDogs = numOfDogs * 2.50;
            double priceFoodForOtherAnimals = numOfOtherAnimals * 4;

            double totalPrice = priceFoodForDogs + priceFoodForOtherAnimals;

            Console.WriteLine(totalPrice + " lv.");
        }
    }
}