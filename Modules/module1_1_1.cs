using System;

class Program
{
    public static void DisplayInfo(string name, string birthdate, string workPhone, string cellPhone)
    {
        Console.WriteLine(name);
        Console.WriteLine(birthdate);
        Console.WriteLine("work " + workPhone);
        Console.WriteLine("cell " + cellPhone);
    }

    static void Main()
    {
        // Unit Test #1
        DisplayInfo("Lucinda Potter", "6/24/1992", "000-000-0101", "000-000-0189");
        Console.WriteLine();

        // Unit Test #2
        DisplayInfo("John Smith", "8/15/1978", "000-111-0101", "000-111-0189");
        Console.WriteLine();

        // Unit Test #3
        DisplayInfo("Chris Johnson", "12/01/1987", "000-222-0101", "000-222-0189");
        Console.WriteLine();

        // Unit Test #4
        DisplayInfo("Robert Hall", "2/27/1949", "000-444-0101", "000-444-0189");
        Console.WriteLine();
    }
}