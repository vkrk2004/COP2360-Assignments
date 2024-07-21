using System;

class TemperaturesComparison
{
    static void Main()
    {
        double[] temperatures = new double[5];

        for (int i = 0; i < 5; i++)
        {
            double temp = GetTemperatureInput($"Enter temperature {i + 1}: ");
            temperatures[i] = temp;
        }

        // Check the order of temperatures
        bool gettingWarmer = true;
        bool gettingCooler = true;

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] < temperatures[i - 1])
                gettingWarmer = false;
            if (temperatures[i] > temperatures[i - 1])
                gettingCooler = false;
        }

        if (gettingWarmer)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (gettingCooler)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        // Display temperatures and average
        Console.WriteLine("Temperatures entered: " + string.Join(", ", temperatures));
        double averageTemp = 0;
        foreach (double temp in temperatures)
        {
            averageTemp += temp;
        }
        averageTemp /= temperatures.Length;
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
