using System;
using System.Collections.Generic;
using System.Linq;

class TemperaturesComparison
{
    static void Main()
    {
        List<double> temperatures = new List<double>();

        for (int i = 0; i < 5; i++)
        {
            double temp = GetTemperatureInput($"Enter temperature {i + 1}: ");
            temperatures.Add(temp);
        }

        // Check the order of temperatures
        bool ascending = temperatures.Zip(temperatures.Skip(1), (a, b) => a <= b).All(x => x);
        bool descending = temperatures.Zip(temperatures.Skip(1), (a, b) => a >= b).All(x => x);

        if (ascending)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (descending)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        // Display temperatures and average
        Console.WriteLine("Temperatures entered: " + string.Join(", ", temperatures));
        double averageTemp = temperatures.Average();
        Console.WriteLine($"Average temperature: {averageTemp:F2}°F");
    }

    static double GetTemperatureInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double temp) && temp >= -30 && temp <= 130)
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Temperature must be between -30 and 130. Please try again.");
            }
        }
    }
}
