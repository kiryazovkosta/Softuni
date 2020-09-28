namespace Ages
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var bounder = ages switch
            {
                var n when n >= 0 && n <= 2 => "baby",
                var n when n >= 3 && n <= 13 => "child",
                var n when n >= 14 && n <= 19 => "teenager",
                var n when n >= 20 && n <= 65 => "adult",
                _ => "elder"
            };

            Console.WriteLine(bounder);
        }
    }
}
