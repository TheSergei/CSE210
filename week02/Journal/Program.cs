using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        string userInput = string.Empty;
        List<string> loadedEntries = new List<string>();

        while (answer != 5)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                string prompt = Write.Prompts();
                Console.WriteLine(prompt);
                userInput = Console.ReadLine();
            }
            else if (answer == 4)
            {
                
                Save.SaveUserInput(userInput, Write.Prompts());
            }
            else if (answer == 3)
            {
                
                loadedEntries = Load.LoadEntries(); 
            }
            else if (answer == 2)
            {
                
                Display.DisplayEntries(loadedEntries);
            }
            else if (answer == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
