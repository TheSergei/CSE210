using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        

        List<int> numbers = new List<int>();
         
         int UserInput = -1;
        while (UserInput != 0)
        {
            Console.WriteLine("Enter number:");
            
            string userResponse = Console.ReadLine();
            UserInput = int.Parse(userResponse);

            if (UserInput != 0)
            {
                numbers.Add(UserInput);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float) sum / numbers.Count);
        Console.WriteLine($"The average is {average}");

        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"this is the max: {max}");

    }
}