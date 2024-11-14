using System;

public class Fraction
{
    private int _numerator; 
    private int _denominator;

 
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        _numerator = numerator;
        _denominator = denominator;
    }

    
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    
    public static Fraction operator +(Fraction a, Fraction b)
    {
        
        int numerator = a._numerator * b._denominator + b._numerator * a._denominator;
        int denominator = a._denominator * b._denominator;
        return new Fraction(numerator, denominator);
    }

    
    public static bool operator ==(Fraction a, Fraction b)
    {
      
        return a._numerator * b._denominator == b._numerator * a._denominator;
    }

 
    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }

    
    public override bool Equals(object obj)
    {
        if (obj is Fraction fraction)
        {
            return this == fraction;
        }
        return false;
    }

    
    public override int GetHashCode()
    {
        return (_numerator, _denominator).GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        
        Fraction f1 = new Fraction(1, 2);   // 1/2
        Fraction f2 = new Fraction(1, 3);   // 1/3

       
        Fraction sum = f1 + f2;
        Console.WriteLine($"Sum: {sum}");  // 5/6

        
        Console.WriteLine(f1 == f2);  // False

        
        Console.WriteLine(f1 != f2);  // True
    }
}
