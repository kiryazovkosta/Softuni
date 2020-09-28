namespace RageExpenses
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var lostGamesCount);
            decimal.TryParse(Console.ReadLine(), out var headsetPrice);
            decimal.TryParse(Console.ReadLine(), out var mousePrice);
            decimal.TryParse(Console.ReadLine(), out var keyboardPrice);
            decimal.TryParse(Console.ReadLine(), out var displayPrice);

            decimal expenses = 0m;

            var headsetCost = (lostGamesCount / 2) * headsetPrice;
            var mouseCost = (lostGamesCount / 3) * mousePrice;
            var keyboardCost = (lostGamesCount / 6) * keyboardPrice;
            var displayCost = (lostGamesCount / 12) * displayPrice;

            expenses = headsetCost + mouseCost + keyboardCost + displayCost;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}