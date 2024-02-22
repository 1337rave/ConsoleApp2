using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers separated by space:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');

        if (numbers.Length != 2)
        {
            Console.WriteLine("Error: Please enter two numbers separated by space.");
            return;
        }

        if (!double.TryParse(numbers[0], out double value) || !double.TryParse(numbers[1], out double percentage))
        {
            Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            return;
        }

        double result = (percentage / 100) * value;

        Console.WriteLine($"Result: {result}");
    }
}
