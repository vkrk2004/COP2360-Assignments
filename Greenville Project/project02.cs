using System;

namespace GreenvilleIdol
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
            Console.WriteLine("1. Calculate expected revenue and compare contestants");
            Console.WriteLine("Please enter your choice:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CalculateAndCompare();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
            }
        }

        static void CalculateAndCompare()
        {
            Console.WriteLine("Enter the number of contestants last year:");
            int contestantsLastYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of contestants this year:");
            int contestantsThisYear = int.Parse(Console.ReadLine());

            int entranceFee = 25;
            int expectedRevenue = contestantsThisYear * entranceFee;

            Console.WriteLine($"Expected revenue for this year's competition: ${expectedRevenue}");

            if (contestantsThisYear > 2 * contestantsLastYear)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
            else if (contestantsThisYear > contestantsLastYear)
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
