using System;

namespace MathOperations
{
    using System.Diagnostics.CodeAnalysis;

    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            string @operator = Console.ReadLine();
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            double result = Calculate(a, b, @operator);
            Console.WriteLine($"{result:F0}");
        }

        private static double Calculate(in double a, in double b, string @operator)
        {
            var result = 0d;
            switch (@operator)
            {
                case "+":
                    result = Sum(a, b);
                    break;
                case "-":
                    result = Minus(a, b);
                    break;
                case "*":
                    result = Multiply(a, b);
                    break;
                case "/":
                    result = Divide(a, b);
                    break;
                default:
                    break;
            }

            return result;
        }

        private static double Divide(in double a, in double b)
        {
            return a / b;
        }


        private static double Multiply(double a, double b)
        {
            return a* b;
        }

        private static double Minus(double a, double b)
        {
            return a - b;
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
