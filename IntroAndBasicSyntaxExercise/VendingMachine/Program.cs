using System;

namespace VendingMachine
{
    using System.Globalization;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var total = 0m;
            var continueAdding = true;
            do
            {
                var userInput = Console.ReadLine();
                if (userInput == "Start")
                {
                    continueAdding = false;
                }
                else
                {
                    decimal price = decimal.Parse(userInput, NumberStyles.Any, CultureInfo.InvariantCulture);
                    if (price != 0.1m && price != 0.2m && price != 0.5m && price != 1m && price != 2m )
                    {
                        Console.WriteLine($"Cannot accept {price}");
                    }
                    else
                    {
                        total += price;
                    }
                }

            } while (continueAdding);

            continueAdding = true;
            do
            {
                var userInput = Console.ReadLine();
                if (userInput == "End")
                {
                    Console.WriteLine($"Change: {total:F2}");
                    continueAdding = false;
                }
                else
                {
                    decimal price = 0M;
                    string product = string.Empty;

                    switch (userInput)
                    {
                        case "Nuts":
                            price = 2.0M;
                            product = "nuts";
                            break;

                        case "Water":
                            price = 0.7M;
                            product = "water";
                            break;

                        case "Crisps":
                            price = 1.5M;
                            product = "crisps";
                            break;

                        case "Soda":
                            price = 0.8M;
                            product = "soda";
                            break;

                        case "Coke":
                            price = 1.0M;
                            product = "coke";
                            break;

                        default:
                            price = 0M;
                            product = "none";
                            break;
                    }

                    if (total >= price)
                    {
                        if (product == "none")
                        {
                            Console.WriteLine("Invalid product");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product}");
                            total -= price;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

            } while (continueAdding);
        }
    }
}
