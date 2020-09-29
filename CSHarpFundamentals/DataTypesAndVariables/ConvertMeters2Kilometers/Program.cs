namespace ConvertMeters2Kilometers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long meters = Convert.ToInt64(Console.ReadLine());
            var kilometers = meters / 1000.00M;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
