using System;

class InchesToCentimetersInteractive
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

        // Unit tests
        TestConversion(5, 12.7);
        TestConversion(50, 127);
        TestConversion(-15, -38.1);
        TestConversion(15994, 40624.76);
    }

    // Method to test conversion and display results
    static void TestConversion(double inputInches, double expectedCentimeters)
    {
        double calculatedCentimeters = inputInches * CentimetersPerInch;
        Console.WriteLine($"Unit Test: {inputInches} inches should be {expectedCentimeters} centimeters.");
        Console.WriteLine($"Calculated Result: {inputInches} inches is {calculatedCentimeters} centimeters.");
        Console.WriteLine($"Test Result: {(Math.Abs(calculatedCentimeters - expectedCentimeters) < 0.01 ? "Passed" : "Failed")}\n");
    }
}
