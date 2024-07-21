using System;

class Perfect
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a number to check if it is a perfect number (or type 'exit' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number))
                Console.WriteLine(IsPerfectNumber(number) ? $"{number} is a perfect number." : $"{number} is not a perfect number.");
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static bool IsPerfectNumber(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
            if (n % i == 0)
                sum += i;

        return sum == n;
    }
}
