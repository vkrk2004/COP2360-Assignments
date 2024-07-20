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
        // Unit Tests
        RunTests();

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

    public static void RunTests()
    {
        if (GetCategory(152) != "Category Four Hurricane")
            Console.WriteLine("Test #1 Failed");

        if (GetCategory(97.913) != "Category Two Hurricane")
            Console.WriteLine("Test #2 Failed");

        if (GetCategory(70.55) != "Not a Hurricane")
            Console.WriteLine("Test #3 Failed");

        if (GetCategory(175.99) != "Category Five Hurricane")
            Console.WriteLine("Test #4 Failed");

        Console.WriteLine("All tests finished!");
    }
}
