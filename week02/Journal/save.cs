using System;
using System.IO;

public class Save
{
    public static void SaveUserInput(string input, string prompt)
    {
        
        Console.WriteLine("Enter the file name to save the entries:");
        string userEntries = Console.ReadLine();  
        string date = DateTime.Now.ToString("MM/dd/yyyy");

        
        using (StreamWriter outputFile = new StreamWriter(userEntries, true))
        {
            outputFile.WriteLine($"Date: {date} - {prompt}");
            outputFile.WriteLine($"{input}");
        }

        Console.WriteLine($"Your entry has been saved to: {userEntries}");
    }
}
