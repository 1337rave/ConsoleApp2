using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four digits:");
        string input = Console.ReadLine();

        if (input.Length != 4)
        {
            Console.WriteLine("Error: Please enter exactly four digits.");
            return;
        }

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Error: Invalid input. Please enter four digits.");
            return;
        }

        Console.WriteLine($"Result: {number}");
    }
}
