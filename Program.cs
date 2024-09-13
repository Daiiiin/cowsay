using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for input
        Console.WriteLine("Tell me what you want to say:");
        string? userInput = Console.ReadLine();

        // Check if user input is valid
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Input cannot be empty!");
            return;
        }

        // Create an instance of CowsayProcess
        CowsayProcess cowsay = new CowsayProcess();

        // Run cowsay with the user's input
        string output = cowsay.RunCowsay(userInput);

        // Display the output from cowsay
        Console.WriteLine("Cowsay says:");
        Console.WriteLine(output);
    }
}
