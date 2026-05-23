using System;

class Program
{
    static void Main(string[] args)
    {
        // Using different constructors
        Fraction frac1 = new Fraction();       // 1/1
        Fraction frac2 = new Fraction(5);      // 5/1
        Fraction frac3 = new Fraction(3, 4);   // 3/4
        Fraction frac4 = new Fraction(1, 3);   // 1/3

        // Display results
        DisplayFraction(frac1);
        DisplayFraction(frac2);
        DisplayFraction(frac3);
        DisplayFraction(frac4);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine("Fraction: " + fraction.GetFractionString());
        Console.WriteLine("Decimal: " + fraction.GetDecimalValue());
        Console.WriteLine();
    }
}