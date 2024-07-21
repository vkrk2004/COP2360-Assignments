using System;

public class Hurricane
{
    public static string GetCategory(double windSpeed)
    {
        if (windSpeed >= 157) return "Category Five Hurricane";
        if (windSpeed >= 130) return "Category Four Hurricane";
        if (windSpeed >= 111) return "Category Three Hurricane";
        if (windSpeed >= 96) return "Category Two Hurricane";
        if (windSpeed >= 74) return "Category One Hurricane";
        return "Not a Hurricane";
    }

    public static void Main(string[] args)
    {
        // User input part
        Console.Write("Enter the wind speed in mph: ");
        if (double.TryParse(Console.ReadLine(), out double windSpeed))
        {
            Console.WriteLine(GetCategory(windSpeed));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
