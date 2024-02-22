using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose conversion option:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        if (int.TryParse(Console.ReadLine(), out int option))
        {
            double temperature;
            string resultUnit;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter temperature in Fahrenheit:");
                    temperature = double.Parse(Console.ReadLine());
                    resultUnit = "Celsius";
                    double celsius = (temperature - 32) * 5 / 9;
                    Console.WriteLine($"Temperature in Celsius: {celsius}");
                    break;
                case 2:
                    Console.WriteLine("Enter temperature in Celsius:");
                    temperature = double.Parse(Console.ReadLine());
                    resultUnit = "Fahrenheit";
                    double fahrenheit = temperature * 9 / 5 + 32;
                    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                    break;
                default:
                    Console.WriteLine("Invalid option choice.");
                    return;
            }
        }
        else
        {
            Console.WriteLine("Invalid option choice.");
        }
    }
}
