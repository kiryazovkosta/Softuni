using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out var age);
            double.TryParse(Console.ReadLine(), out var grade);
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
