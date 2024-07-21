using System;

namespace GreenvilleRevenueApp
{
    class GreenvilleRevenue
    {
        private string motto = "************************************\n*  The stars shine in Greenville.  *\n************************************";
        private int lastYearContestants;
        private int thisYearContestants;

        static void Main(string[] args)
        {
            GreenvilleRevenue app = new GreenvilleRevenue();
            app.DisplayMotto();
            app.DisplayMenu();
        }

        public void DisplayMotto()
        {
            Console.WriteLine(motto);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");

            MenuSelection();
        }

        public void MenuSelection()
        {
            Console.Write("Select a menu option (1-2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EnterContestantsData();
                    CalculateRevenueAndCompare();
                    DisplayMotto();
                    DisplayMenu();
                    break;
                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    MenuSelection();
                    break;
            }
        }

        public void EnterContestantsData()
        {
            Console.Write("Enter the number of contestants from last year: ");
            while (!int.TryParse(Console.ReadLine(), out lastYearContestants))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the number of contestants from last year: ");
            }

            Console.Write("Enter the number of contestants for this year: ");
            while (!int.TryParse(Console.ReadLine(), out thisYearContestants))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the number of contestants for this year: ");
            }
        }

        public void CalculateRevenueAndCompare()
        {
            int revenue = thisYearContestants * 25;
            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
            Console.WriteLine($"Revenue expected this year is ${revenue}");

            if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("It is true that this year's competition is bigger than last year's.");
            }
            else if (thisYearContestants < lastYearContestants)
            {
                Console.WriteLine("It is true that last year's competition was bigger than this year's.");
            }
            else
            {
                Console.WriteLine("It is true that this year's competition is the same size as last year's.");
            }
        }
    }
}
