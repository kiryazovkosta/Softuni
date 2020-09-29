using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double volume = ((length * width ) / 3) * height;
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
