using System;

namespace ListManipulationBasics
{
    using System.Collections;
    using System.Collections.Generic;
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
                var input = Console.ReadLine();
                if (input.Equals("end"))
                {
                    continueReading = false;
                }
                else
                {
                    var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    switch (tokens[0])
                    {
                        case "Add":
                            Add(numbers, int.Parse(tokens[1]));
                            break;

                        case "Remove":
                            Remove(numbers, int.Parse(tokens[1]));
                            break;

                        case "RemoveAt":
                            RemoveAt(numbers, int.Parse(tokens[1]));
                            break;

                        case "Insert":
                            Insert(numbers, int.Parse(tokens[1]), int.Parse(tokens[2]));
                            break;

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Insert(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }

        private static void RemoveAt(IList numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        private static void Remove(ICollection<int> numbers, int number)
        {
            numbers.Remove(number);
        }

        private static void Add(ICollection<int> numbers, int number)
        {
            numbers.Add(number);
        }
    }
}
