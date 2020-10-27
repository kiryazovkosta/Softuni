using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int power = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            double pow = RaiseToPower(number, power);
            Console.WriteLine(pow);
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
    }
}
