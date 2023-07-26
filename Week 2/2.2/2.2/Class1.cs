using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the bill total: ");
        double billTotal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the tip percentage (e.g., 15 for 15%): ");
        double tipPercentage = Convert.ToDouble(Console.ReadLine());

        double tipAmount = billTotal * (tipPercentage / 100);
        double grandTotal = billTotal + tipAmount;

        Console.WriteLine("Tip amount: " + tipAmount.ToString("0.00"));
        Console.WriteLine("Grand total: " + grandTotal.ToString("0.00"));

        Console.ReadLine();
    }
}
