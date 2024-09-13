using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tell me what you want to say:");
        string? userInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Input cannot be empty!");
            return;
        }

        CowsayProcess cowsay = new CowsayProcess();
        string output = cowsay.RunCowsay(userInput);

        Console.WriteLine("Cowsay says:");
        Console.WriteLine(output);
    }
}
