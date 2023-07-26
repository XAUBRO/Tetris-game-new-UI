using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "details.txt";

        // Write details to the file
        WriteDetailsToFile(fileName);

        // Read and print details from the file
        ReadAndPrintDetailsFromFile(fileName);

        Console.ReadLine();
    }

    static void WriteDetailsToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Name: John Doe");
                writer.WriteLine("Age: 30");
                writer.WriteLine("Address: 123 Main Street");
            }
            Console.WriteLine("Details saved to file: " + fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing details to file: " + ex.Message);
        }
    }

    static void ReadAndPrintDetailsFromFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading details from file: " + ex.Message);
        }
    }
}
