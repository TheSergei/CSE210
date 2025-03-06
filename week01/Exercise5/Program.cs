using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       DisplayMessage();
       string UserName = PromptUserName();
       int UserNumber = PromptUserNumber();
       int square = TotalSquare(UserNumber);
       Display(UserName, square);
    }
     static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    static string PromptUserName()
    {
        Console.Write("whats your name?: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int TotalSquare(int favoriteNumber)
    {
        int squared = favoriteNumber * favoriteNumber;
        return squared;
    }

    static void Display(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");

    }


}