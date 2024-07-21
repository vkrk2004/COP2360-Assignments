using System;

class HomeSales
{
    static void Main()
    {
        double totalD = 0.0, totalE = 0.0, totalF = 0.0;
        char initial;
        double saleAmount;

        while (true)
        {
            Console.Write("Enter the salesperson's initial (D, E, F) or Z to quit: ");
            initial = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Z')
            {
                break;
            }

            if (initial != 'D' && initial != 'E' && initial != 'F')
            {
                Console.WriteLine("Error: Invalid initial. Please enter D, E, or F.");
                continue;
            }

            Console.Write("Enter the sale amount: ");
            if (!double.TryParse(Console.ReadLine(), out saleAmount))
            {
                Console.WriteLine("Error: Invalid sale amount. Please enter a valid number.");
                continue;
            }

            if (initial == 'D') totalD += saleAmount;
            else if (initial == 'E') totalE += saleAmount;
            else if (initial == 'F') totalF += saleAmount;
        }

        double grandTotal = totalD + totalE + totalF;
        string highestSalesperson = totalD > totalE ? (totalD > totalF ? "D" : "F") : (totalE > totalF ? "E" : "F");

        Console.WriteLine("\nSales Summary:");
        Console.WriteLine($"Total sales by Danielle (D): ${totalD:F2}");
        Console.WriteLine($"Total sales by Edward (E): ${totalE:F2}");
        Console.WriteLine($"Total sales by Francis (F): ${totalF:F2}");
        Console.WriteLine($"Grand Total Sales: ${grandTotal:F2}");
        Console.WriteLine($"Highest sales made by: {highestSalesperson}");
    }
}