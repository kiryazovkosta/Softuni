using System;

namespace Calculations
{
    using System.ComponentModel;

    class Program
    {
        static void Main(string[] args)
        {
            // add, multiply, subtract, divide
            string command = Console.ReadLine();
            double first = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double second = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            double result = 0;
            switch (command)
            {
                case "add":
                    result = Add(first, second);
                    break;
                case "multiply":
                    result = Multiply(first, second);
                    break;
                case "subtract":
                    result = Subtract(first, second);
                    break;
                case "divide":
                    result = Divide(first, second);
                    break;
                default:
                    break;
            }

            Console.WriteLine(result);
        }

        private static double Divide(double first, double second)
        {
            return first / second;
        }

        private static double Subtract(double first, double second)
        {
            return first - second;
        }

        private static double Multiply(double first, double second)
        {
            return first * second;
        }

        private static double Add(double first, double second)
        {
            return first + second;
        }
    }
}
