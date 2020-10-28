namespace PalindromeIntegers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            bool continueReading = true;
            do
            {
                string input = Console.ReadLine() ?? "END";
                if (input.Equals("END"))
                {
                    continueReading = false;
                }
                else
                {
                    bool isPalindrome = true;
                    for (int startIndex = 0, endIndex = input.Length - 1; startIndex < (input.Length / 2) + 1 ; startIndex++, endIndex--)
                    {
                        if (input[startIndex] != input[endIndex])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    Console.WriteLine(isPalindrome.ToString().ToLower());
                }

            } while (continueReading);
        }
    }
}