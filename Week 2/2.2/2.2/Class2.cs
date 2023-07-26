using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value of 'n': ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int minimum = numbers[0];
        int maximum = numbers[0];

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] < minimum)
                minimum = numbers[i];

            if (numbers[i] > maximum)
                maximum = numbers[i];
        }

        Console.WriteLine("Minimum number: " + minimum);
        Console.WriteLine("Maximum number: " + maximum);

        Console.ReadLine();
    }
}
