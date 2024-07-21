using System;

namespace GreenvilleIdol2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Welcome to Greenville Idol!");
            Console.WriteLine("1. Calculate Revenue and Compare Contestants");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateAndCompare();
                    break;
                case "2":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowMenu();
                    break;
            }
        }

        static void CalculateAndCompare()
        {
            int lastYearContestants = GetValidNumberOfContestants("Enter the number of contestants last year (0-30): ");
            int thisYearContestants = GetValidNumberOfContestants("Enter the number of contestants this year (0-30): ");

            CompareContestants(lastYearContestants, thisYearContestants);
        }

        static int GetValidNumberOfContestants(string prompt)
        {
            int numContestants;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out numContestants) && numContestants >= 0 && numContestants <= 30)
                {
                    return numContestants;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a number between 0 and 30.");
                }
            }
        }

        static void CompareContestants(int lastYearContestants, int thisYearContestants)
        {
            if (thisYearContestants > 2 * lastYearContestants)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
            else if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
            else
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }
        }
    }
}
