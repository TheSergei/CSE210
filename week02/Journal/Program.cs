using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        static void TypeChoices(string text, int delay = 20)
        {
            
            foreach(char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        } 
        TypeChoices("Welcome! This journal is private and secure. Please feel free to type whatever you'd like!");
        Console.WriteLine("");
        int answer = 0;
        string userInput = string.Empty;
        List<string> loadedEntries = new List<string>();
        Thread.Sleep(2000);
        while (answer != 5)
        {
            TypeChoices("Please select one of the following:");
            Console.WriteLine("");
            TypeChoices("1. Write");
            Console.WriteLine("");
            TypeChoices("2. Display");
            Console.WriteLine("");
            TypeChoices("3. Load");
            Console.WriteLine("");
            TypeChoices("4. Save");
            Console.WriteLine("");
            TypeChoices("5. Quit");
            Console.WriteLine("");
            TypeChoices("What would you like to do?");
            Console.WriteLine("");
            

            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                TypeChoices("Generating random prompt, please wait...");
                Thread.Sleep(3000);
                Console.WriteLine("");
                string prompt = Write.Prompts();
                Console.WriteLine(prompt);
                userInput = Console.ReadLine();
                TypeChoices("Thank you for writing today!");
                Thread.Sleep(2500);
                Console.WriteLine("");
            }
            else if (answer == 4)
            {
                
                Save.SaveUserInput(userInput, Write.Prompts());
                Thread.Sleep(2500);
                Console.WriteLine("");
            }
            else if (answer == 3)
            {
                loadedEntries = Load.LoadEntries();
                Thread.Sleep(2500);
                Console.WriteLine("");
            }
            else if (answer == 2)
            {
                TypeChoices("Gathering data, please wait...");
                Thread.Sleep(3000);
                Console.WriteLine("");
                Display.DisplayEntries(loadedEntries);
                Console.WriteLine("");
            }
            else if (answer == 5)
            {
                TypeChoices("Goodbye!");
            }
        }
    }
}
