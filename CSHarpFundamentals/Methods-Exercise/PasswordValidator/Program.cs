using System;

namespace PasswordValidator
{
    class Program
    {
        static readonly int MinimumValidDigitsCount = 2;
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        private static void ValidatePassword(string password)
        {
            bool isLengthValid = ValidatePasswordLength(password);
            bool isSymbolsValid = ValidatePasswordSymbols(password);
            bool isConstraintsValid = ValidatePasswordConstraints(password);
            if (isLengthValid && isSymbolsValid && isConstraintsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidatePasswordConstraints(string password)
        {
            bool isValid = false;
            int digitCounter = 0;
            foreach (var letter in password)
            {
                if (char.IsDigit(letter))
                {
                    digitCounter++;
                }
            }

            if (digitCounter >= MinimumValidDigitsCount)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            return isValid;
        }

        private static bool ValidatePasswordSymbols(string password)
        {
            bool isValid = true;
            foreach (var letter in password)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        private static bool ValidatePasswordLength(string password)
        {
            bool isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            return isValid;
        }
    }
}
