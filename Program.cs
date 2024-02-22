using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers (start and end of the range):");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        Console.WriteLine($"Even numbers in the range from {start} to {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
