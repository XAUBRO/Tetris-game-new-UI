using System;
using System.IO;

namespace FileCopyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFileName = "mytest.txt";
            string targetFileName = "mynewtest.txt";


            using (StreamWriter writer = new StreamWriter(sourceFileName))
            {
                writer.WriteLine("Hello and Welcome");
                writer.WriteLine("It is the first content");
                writer.WriteLine("of the text file mytest.txt");
            }

            Console.WriteLine($"Here is the content of the file {sourceFileName}:");
            using (StreamReader reader = new StreamReader(sourceFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }


            File.Copy(sourceFileName, targetFileName, true);


            Console.WriteLine($"\nThe file {sourceFileName} successfully copied to the name {targetFileName} in the same directory.");
            Console.WriteLine($"\nHere is the content of the file {targetFileName}:");
            using (StreamReader reader = new StreamReader(targetFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
