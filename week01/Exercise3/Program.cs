using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != MagicNumber)
        {
            Console.WriteLine("what is your guess?");
            guess = int.Parse(Console.ReadLine());

             if  (guess > MagicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < MagicNumber)
            {
                Console.WriteLine("higher");
            }
            else 
            {
                Console.WriteLine("you guessed it!");
            }
        }
    }                    
}
