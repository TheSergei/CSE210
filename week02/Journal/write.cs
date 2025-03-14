using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Write
{
    public static string Prompts()
    {
        List<string> prompts = new List<string>
        {
            "What was the best part of my day?",
            "What was the worst part of my day?",
            "What can I do differently tomorrow?",
            "How did I see the hand of the Lord in my life today?",
            "What is the most important thing I can do right now?"
        };

        Random rand = new Random();
        int index = rand.Next(prompts.Count);  

        return prompts[index];
    }
}