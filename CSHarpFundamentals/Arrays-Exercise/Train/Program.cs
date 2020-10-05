namespace Train
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int[] wagons = new int[wagonsCount];
            long peopleSum = 0;
            for (int wagonIndex = 0; wagonIndex < wagonsCount; wagonIndex++)
            {
                wagons[wagonIndex] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                peopleSum += wagons[wagonIndex];
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(peopleSum);
        }
    }
}