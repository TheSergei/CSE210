using System;
using System.Collections.Generic;

public class Display
{
    public static void DisplayEntries(List<string> entries)
    {
        
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}
