using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string Operator = Console.ReadLine();

            double result = 0.0;
            string evenOdd = "";
            double rest = 0.0;

            if (Operator == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                Console.WriteLine(n1 + " " + Operator + " " + n2 + " = " + result + " - " + evenOdd);
            }
            else if (Operator == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine(n1 + " " + Operator + " " + n2 + " = " + result + " - " + evenOdd);
            }
            else if (Operator == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine(n1 + " " + Operator + " " + n2 + " = " + result + " - " + evenOdd);
            }
            else if (Operator == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide " + n1 + " by zero");
                }
                else
                {
                    result = n1 / (n2 * 1.0);
                    Console.WriteLine(n1 + " / " + n2 + " = " + ($"{result:F2}"));
                }

            }
            else if (Operator == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide " + n1 + " by zero");
                }
                else
                {
                    rest = n1 % n2;
                    Console.WriteLine(n1 + " % " + n2 + " = " + rest);
                }

            }

        }
    }
}
