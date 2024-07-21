using System;

class HomeSales
{
    static void Main()
    {
        double totalD = 0.0;
        double totalE = 0.0;
        double totalF = 0.0;
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
                Console.WriteLine("Error: Invalid initial entered. Please enter D, E, or F.");
                continue;
            }

            Console.Write("Enter the amount of the sale: ");
            if (!double.TryParse(Console.ReadLine(), out saleAmount))
            {
                Console.WriteLine("Error: Invalid sale amount entered. Please enter a valid number.");
                continue;
            }

            switch (initial)
            {
                case 'D':
                    totalD += saleAmount;
                    break;
                case 'E':
                    totalE += saleAmount;
                    break;
                case 'F':
                    totalF += saleAmount;
                    break;
            }
        }

        double grandTotal = totalD + totalE + totalF;
        string highestSalesperson = "D";
        double highestTotal = totalD;

        if (totalE > highestTotal)
        {
            highestSalesperson = "E";
            highestTotal = totalE;
        }

        if (totalF > highestTotal)
        {
            highestSalesperson = "F";
            highestTotal = totalF;
        }

        Console.WriteLine("\nSales Summary:");
        Console.WriteLine($"Total sales by Danielle (D): ${totalD:F2}");
        Console.WriteLine($"Total sales by Edward (E): ${totalE:F2}");
        Console.WriteLine($"Total sales by Francis (F): ${totalF:F2}");
        Console.WriteLine($"Grand Total Sales: ${grandTotal:F2}");
        Console.WriteLine($"Highest sales made by: {highestSalesperson}");
    }
}
