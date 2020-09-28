namespace Login
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] stringArray = username?.ToCharArray();
            Array.Reverse(stringArray);
            string password = new string(stringArray);

            int loginAttempts = 1;

            while (Console.ReadLine() != password  && loginAttempts <= 3)
            {
                loginAttempts++;
                Console.WriteLine("Incorrect password. Try again.");
            }

            if (loginAttempts >= 4)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
