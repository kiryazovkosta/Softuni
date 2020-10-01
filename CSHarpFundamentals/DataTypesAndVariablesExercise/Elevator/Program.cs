using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int capacity = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            int elevatorCourses = (int)Math.Ceiling((double)persons / capacity);
            Console.WriteLine(elevatorCourses);
        }
    }
}
