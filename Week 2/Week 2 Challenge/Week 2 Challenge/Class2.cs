using System;

namespace UserLoginAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAttempts = 3;
            int attempts = 0;
            string validUserId = "user123";
            string validPassword = "password123";

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter your User ID: ");
                string userId = Console.ReadLine();

                Console.WriteLine("Enter your Password: ");
                string password = Console.ReadLine();

                if (userId == validUserId && password == validPassword)
                {
                    Console.WriteLine("Login Successful!");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Invalid User ID or Password. Attempts left: {maxAttempts - attempts}");
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine("Login Failed. Maximum attempts exceeded.");
            }
        }
    }
}
