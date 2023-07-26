using System;


public class Maths
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }

    public static float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }

    public static float Multiply(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Add (integers)");
        Console.WriteLine("2. Add (decimals)");
        Console.WriteLine("3. Multiply (floats)");
        Console.WriteLine("4. Multiply (floats, 3 numbers)");

        Console.WriteLine("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the first integer: ");
                int int1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second integer: ");
                int int2 = Convert.ToInt32(Console.ReadLine());

                int sum = Maths.Add(int1, int2);
                Console.WriteLine($"The sum is: {sum}");
                break;

            case 2:
                Console.WriteLine("Enter the first decimal: ");
                decimal dec1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the second decimal: ");
                decimal dec2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the third decimal: ");
                decimal dec3 = Convert.ToDecimal(Console.ReadLine());

                decimal sumDec = Maths.Add(dec1, dec2, dec3);
                Console.WriteLine($"The sum is: {sumDec}");
                break;

            case 3:
                Console.WriteLine("Enter the first float: ");
                float float1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter the second float: ");
                float float2 = Convert.ToSingle(Console.ReadLine());

                float product = Maths.Multiply(float1, float2);
                Console.WriteLine($"The product is: {product}");
                break;

            case 4:
                Console.WriteLine("Enter the first float: ");
                float floatA = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter the second float: ");
                float floatB = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter the third float: ");
                float floatC = Convert.ToSingle(Console.ReadLine());

                float productThree = Maths.Multiply(floatA, floatB, floatC);
                Console.WriteLine($"The product is: {productThree}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

