using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (type)
            {
                case "Roses":

                    if (num > 80)
                    {
                        price = num * 5;
                        double discount = price * 0.1;
                        double totalPrice = price - discount;
                        double sumLeft = budjet - totalPrice;
                        if (budjet >= totalPrice)
                        {
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }

                    }
                    else
                    {
                        double totalPrice = num * 5;
                        double sumLeft = budjet - totalPrice;
                        if (budjet >= totalPrice)
                        {
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }
                    break;

                case "Dahlias":

                    if (num > 90)
                    {
                        price = num * 3.80;
                        double discount = price * 0.15;
                        double totalPrice = price - discount;
                        double sumLeft = budjet - totalPrice;
                        if (budjet >= totalPrice)
                        {
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }

                    }
                    else
                    {
                        double totalPrice = num * 3.80;
                        double sumLeft = budjet - totalPrice;
                        if (budjet >= totalPrice)
                        {
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }


                    break;

                case "Tulips":
                    if (num > 80)
                    {
                        price = num * 2.80;
                        double discount = price * 0.15;
                        double totalPrice = price - discount;
                        double sumLeft = budjet - totalPrice;
                        if (budjet >= totalPrice)
                        {
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }

                    }
                    else
                    {
                        double totalPrice = num * 2.80;
                        double sumLeft = budjet - totalPrice;
                        if (budjet >= totalPrice)
                        {
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }
                    break;

                case "Narcissus":
                    if (num < 120)
                    {
                        price = num * 3;
                        double overPrice = price * 0.15;
                        double totalPrice = price + overPrice;
                        if (budjet >= totalPrice)
                        {
                            double sumLeft = budjet - totalPrice;
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }
                    else
                    {
                        price = num * 3;
                        if (budjet >= price)
                        {
                            double sumLeft = budjet - price;
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < price)
                        {
                            double sumPlus = price - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }
                    break;

                case "Gladiolus":
                    if (num < 80)
                    {
                        price = num * 2.50;
                        double overPrice = price * 0.2;
                        double totalPrice = price + overPrice;
                        if (budjet >= totalPrice)
                        {
                            double sumLeft = budjet - totalPrice;
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < totalPrice)
                        {
                            double sumPlus = totalPrice - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }
                    else
                    {
                        price = num * 2.50;
                        if (budjet >= price)
                        {
                            double sumLeft = budjet - price;
                            Console.WriteLine("Hey, you have a great garden with " + num + " " + type + " and " + ($"{sumLeft:F2}") + " leva left.");
                        }
                        else if (budjet < price)
                        {
                            double sumPlus = price - budjet;
                            Console.WriteLine("Not enough money, you need " + ($"{sumPlus:F2}") + " leva more.");
                        }
                    }

                    break;
            }
        }
    }
}