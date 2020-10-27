using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double height = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            double area = CalculateArea(width, height);
            Console.WriteLine($"{area}");
        }

        private static double CalculateArea(in double width, in double height)
        {
            return width * height;
        }
    }
}
