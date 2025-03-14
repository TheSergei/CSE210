using System;
using System.IO;
using System.Threading;

public class Save
{
    public static void SaveUserInput(string input, string prompt)
    {
        Console.WriteLine("Enter the file name to save the entries:");
        string userEntries = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");

        Console.WriteLine("Enter your user name please.");
        string userName = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(userEntries, true))
        {
            outputFile.WriteLine($"USER - {userName} ON DATE: {date} - PROMPT: {prompt} SAID: ");
            outputFile.WriteLine($"{input}");
        }

        Console.WriteLine("Saving, please wait...");
        Thread.Sleep(2000);
        Console.WriteLine($"Your entry has been saved to: {userEntries}");
    }
}