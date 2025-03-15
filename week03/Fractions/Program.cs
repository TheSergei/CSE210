using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        System.Console.WriteLine(f1.GetFractionString());
        System.Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction();
        System.Console.WriteLine(f2.GetFractionString());
        System.Console.WriteLine(f2.GetDecimalValue());
    }
}