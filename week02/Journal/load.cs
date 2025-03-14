using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

public class Load
{
    public static List<string> LoadEntries()
    {
        
        Console.WriteLine("Please enter the file name to load entries from:");
        string filename = Console.ReadLine();
        Console.WriteLine("Loading, please wait...");
        Thread.Sleep(3000);
        
        List<string> entries = new List<string>();

        
        string[] fileEntries = File.ReadAllLines(filename);

        foreach (string entry in fileEntries)
        {
            
            entries.Add(entry);
        }

        return entries; 
    }
}
