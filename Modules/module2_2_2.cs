using System;

class MoveEstimator
{
    static void Main()
    {
        // Constants for rates
        const decimal BaseRate = 200m;
        const decimal HourlyRate = 150m;
        const decimal MileRate = 2m;

        // Prompt user for inputs
        Console.WriteLine("Enter the estimated number of hours for the move:");
        double hours = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the estimated number of miles for the move:");
        double miles = double.Parse(Console.ReadLine());

        // Calculate total moving fee
        decimal totalFee = BaseRate + (decimal)hours * HourlyRate + (decimal)miles * MileRate;

        // Display the total moving fee
        Console.WriteLine($"The total moving fee is: ${totalFee:F2}");
    }
}
