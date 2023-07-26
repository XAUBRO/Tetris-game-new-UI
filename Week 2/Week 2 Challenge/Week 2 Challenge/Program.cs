using System;

namespace TemperatureState
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            string weatherMessage;

            if (temperature < 0)
                weatherMessage = "Freezing weather";
            else if (temperature >= 0 && temperature <= 10)
                weatherMessage = "Freezing weather";
            else if (temperature >= 11 && temperature <= 20)
                weatherMessage = "Very Cold weather";
            else if (temperature >= 21 && temperature <= 35)
                weatherMessage = "Cold weather";
            else if (temperature >= 36 && temperature <= 50)
                weatherMessage = "Normal in Weather";
            else if (temperature >= 51 && temperature <= 65)
                weatherMessage = "Its Hot";
            else if (temperature >= 66 && temperature <= 80)
                weatherMessage = "Its Very Hot";
            else
                weatherMessage = "Extremely Hot";

            Console.WriteLine(weatherMessage);
        }
    }
}
