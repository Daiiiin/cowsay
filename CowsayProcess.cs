using System;
using System.Diagnostics;

public class CowsayProcess
{
    public string RunCowsay(string inputText)
    {
        // Setup the process to run cowsay directly inside WSL (Linux environment)
        Process process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "/usr/games/cowsay", // Directly call the cowsay command
                Arguments = inputText, // Pass the input text as an argument
                RedirectStandardOutput = true, // Redirect standard output to capture it
                RedirectStandardError = true,  // Redirect standard error
                UseShellExecute = false, // Do not use the system shell to start the process
                CreateNoWindow = true // Do not create a window for the process
            }
        };

        // Start the process
        process.Start();

        // Read the output from cowsay
        string result = process.StandardOutput.ReadToEnd();

        // Ensure the process has exited before returning
        process.WaitForExit();

        return result;
    }
}
