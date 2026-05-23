public class Fraction
{
    // Private attributes
    private int numerator;
    private int denominator;

    // Constructor with no parameters
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int top)
    {
        numerator = top;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator
    public void SetDenominator(int bottom)
    {
        denominator = bottom;
    }

    // Returns fraction as a string
    public string GetFractionString()
    {
        return numerator + "/" + denominator;
    }

    // Returns decimal value of fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}