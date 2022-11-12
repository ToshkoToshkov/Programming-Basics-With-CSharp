using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());

            double cakePrice = hallPrice * 0.2;

            double bevereges = cakePrice - cakePrice * 0.45;

            double animatorPrice = hallPrice / 3;

            double totalPrice = hallPrice + cakePrice + bevereges + animatorPrice;

            Console.WriteLine(totalPrice);

        }
    }
}
