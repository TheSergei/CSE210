using System;
using System.IO;
using System.Collections.Generic;

public class Load
{
    public static List<string> LoadEntries()
    {
        
        Console.WriteLine("Please enter the file name to load entries from:");
        string filename = Console.ReadLine();

        
        List<string> entries = new List<string>();

        
        string[] fileEntries = File.ReadAllLines(filename);

        foreach (string entry in fileEntries)
        {
            
            entries.Add(entry);
        }

        return entries; 
    }
}
