using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a date (DD.MM.YYYY):");
        string inputDate = Console.ReadLine();

        if (DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
        {
            string season = GetSeason(date.Month);
            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Error: Invalid date format. Please enter date in the format DD.MM.YYYY.");
        }
    }

    static string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Invalid Month";
        }
    }
}
