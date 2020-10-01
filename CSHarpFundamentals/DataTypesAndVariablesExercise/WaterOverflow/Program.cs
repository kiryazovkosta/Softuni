using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCapacity = 255;
            int currentCapacity = 0;
            int insertNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int insertIndex = 0; insertIndex < insertNumber; insertIndex++)
            {
                int insertLiters = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                if (insertLiters + currentCapacity > totalCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentCapacity += insertLiters;
                }
            }

            Console.WriteLine(currentCapacity);
        }
    }
}
