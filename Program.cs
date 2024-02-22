using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number from 1 to 100:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Error: The entered number is not within the range from 1 to 100.");
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
        else
        {
            Console.WriteLine("Error: The entered value is not an integer.");
        }
    }
}
