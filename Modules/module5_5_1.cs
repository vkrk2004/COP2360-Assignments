using System;

class HomeSales2
{
    static string[] salespeople = { "Danielle", "Edward", "Francis" };
    static char[] initials = { 'D', 'E', 'F' };
    static double[] sales = { 0.0, 0.0, 0.0 };
    static double grandTotal = 0.0;
    static double highestSale = 0.0;
    static string highestSalePerson = "";

    static int FindSalespersonIndex(char initial)
    {
        for (int i = 0; i < initials.Length; i++)
            if (initials[i] == initial) return i;
        return -1;
    }

    static void AddSales(char initial, double saleAmount)
    {
        int index = FindSalespersonIndex(initial);
        if (index != -1)
        {
            sales[index] += saleAmount;
            grandTotal += saleAmount;
            if (saleAmount > highestSale)
            {
                highestSale = saleAmount;
                highestSalePerson = salespeople[index];
            }
            Console.WriteLine($"Added ${saleAmount} to {salespeople[index]}'s sales.");
        }
        else
        {
            Console.WriteLine("Salesperson not found.");
        }
    }

    static void PrintSales()
    {
        for (int i = 0; i < salespeople.Length; i++)
            Console.WriteLine($"{salespeople[i]} (initial: {initials[i]}) has accumulated sales of ${sales[i]:F2}.");
        Console.WriteLine($"\nGrand Total Sales: ${grandTotal:F2}");
        Console.WriteLine($"Highest Sale: ${highestSale:F2} by {highestSalePerson}");
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the initial of the salesperson (D, E, F) or 'Q' to quit:");
            char initial = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (initial == 'Q') break;
            if (Array.IndexOf(initials, initial) == -1)
            {
                Console.WriteLine("Invalid input. Please enter D, E, or F.");
                continue;
            }

            Console.WriteLine("Enter the sale amount:");
            if (double.TryParse(Console.ReadLine(), out double saleAmount))
                AddSales(initial, saleAmount);
            else
                Console.WriteLine("Invalid sale amount. Please enter a valid number.");
        }

        Console.WriteLine("\nAccumulated sales:");
        PrintSales();
    }
}
