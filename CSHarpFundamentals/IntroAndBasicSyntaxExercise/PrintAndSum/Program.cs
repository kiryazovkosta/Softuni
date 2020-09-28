namespace PrintAndSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var beginNumber);
            int.TryParse(Console.ReadLine(), out var endNumber);

            long sum = 0;
            for (int number = beginNumber; number <= endNumber; number++)
            {
                Console.Write(number);
                if (number < endNumber)
                {
                    Console.Write(" ");
                }

                sum += number;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
