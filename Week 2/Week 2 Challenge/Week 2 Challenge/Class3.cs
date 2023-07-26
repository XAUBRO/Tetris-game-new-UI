using System;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the desired width: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = width; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
