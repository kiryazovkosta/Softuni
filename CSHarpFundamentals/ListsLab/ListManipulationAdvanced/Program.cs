using System;

namespace ListManipulationAdvanced
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToList();

            bool continueReading = true;
            while (continueReading)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "end")
                {
                    continueReading = false;
                }
                else
                {
                    string[] commandParts = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    switch (commandParts[0]) 
                    {
                        case "Contains":
                            Contains(numbers, int.Parse(commandParts[1]));
                            break;

                        case "PrintEven":
                            PrintEven(numbers);
                            break;

                        case "PrintOdd":
                            PrintOdd(numbers);
                            break;

                        case "GetSum":
                            GetSum(numbers);
                            break;

                        case "Filter":
                            Filter(numbers, commandParts[1], int.Parse(commandParts[2]));
                            break;

                        default:
                            break;
                    };
                }

            }
        }

        private static void Filter(IEnumerable<int> numbers, string expression, int pattern)
        {
            var subNumbers = new List<int>();
            if (expression == "<")
            {
                subNumbers = numbers.Where(n => n < pattern).ToList();
            }
            else if (expression == ">")
            {
                subNumbers = numbers.Where(n => n > pattern).ToList();
            }
            else if (expression == ">=")
            {
                subNumbers = numbers.Where(n => n >= pattern).ToList();
            }
            else if (expression == "<=")
            {
                subNumbers = numbers.Where(n => n <= pattern).ToList();
            }

            Console.WriteLine(string.Join(" ", subNumbers));
        }

        private static void GetSum(IEnumerable<int> numbers)
        {
            Console.WriteLine(numbers.Sum());
        }

        private static void PrintOdd(IEnumerable<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
        }

        private static void PrintEven(IEnumerable<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
        }

        private static bool Contains(IEnumerable<int> numbers, int pattern)
        {
            bool contains = false;
            foreach (var number in numbers)
            {
                if (number == pattern)
                {
                    contains = true;
                    break;
                }
            }

            Console.WriteLine(contains == true ? "Yes" : "No such number");
            return contains;
        }
    }
}
