using System;
using System.Collections.Generic;
using System.Threading;

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
