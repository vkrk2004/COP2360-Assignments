using System;

 class Twitter
{static void Main(string[] args)
    {
        Console.WriteLine("Enter your message:");
        string message = Console.ReadLine();

        if (message.Length < 140) // Changed to less than 140
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }
    }
}