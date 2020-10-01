using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            long yield = long.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            long total = 0;
            long daysCounter = 0;

            while (yield >= 100)
            {
                total += (yield - 26);
                yield -= 10;
                daysCounter++;
                if (yield < 100)
                {
                    total -= 26;
                }
            }

            Console.WriteLine($"{daysCounter}");
            Console.WriteLine($"{total}");
        }
    }
}
