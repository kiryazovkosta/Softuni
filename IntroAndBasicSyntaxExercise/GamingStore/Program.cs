using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal.TryParse(Console.ReadLine(), out var startBalance);
            decimal currentBalance = startBalance;
            decimal spendBalance = 0m;

            while (true)
            {
                if (currentBalance == 0M)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                string userInput = Console.ReadLine();
                if (userInput == "Game Time")
                {
                    break;
                }

                decimal gamePrice = 0m;
                switch (userInput)
                {
                    case "OutFall 4":
                        gamePrice = 39.99m;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99m;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99m;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99m;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99m;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99m;
                        break;
                    default:
                        break;
                }

                if (gamePrice == 0m)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    if (gamePrice > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {userInput}");
                        currentBalance -= gamePrice;
                        spendBalance += gamePrice;
                    }
                }
            }

            Console.WriteLine($"Total spent: ${spendBalance:F2}. Remaining: ${startBalance-spendBalance:F2}");
        }
    }
}
