using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your GPA?");
        string gpa = Console.ReadLine();
        int number = int.Parse(gpa);

        string letter = "";
      
        if (number > 90)
        {
            letter = "A";
        }
        else if (number > 80 && number < 90)
        {
            letter = "B";
        }
        else if (number > 70 && number < 80)
        {
            letter = "C";
        }
        else if (number > 60 && number < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is : {letter}");

        if (number >= 70 )
        {
            Console.WriteLine("you passed the class!");
        }
        else 
        {
            Console.WriteLine("you failed buddy.");
        }
    }

}