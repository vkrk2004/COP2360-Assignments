using System;

class InchesToCentimeters
{
    // Named constant for centimeters in an inch
    const double CentimetersPerInch = 2.54;

    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter measurement in inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());

        // Calculate measurement in centimeters
        double centimeters = inches * CentimetersPerInch;

        // Display the measurement
        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
    }
}
