using System;

static class MathHelper
{
   
    public static int Add(int a, int b)
    {
        return a + b;
    }

    
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

   
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

   
    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is impossible.");
        }
        return (double)a / b;
    }
}

class Program
{
    static void Main()
    {
        int a = 20;
        int b = 5;

        
        Console.WriteLine("Add: " + MathHelper.Add(a, b));
        Console.WriteLine("Subtract: " + MathHelper.Subtract(a, b));
        Console.WriteLine("Multiply: " + MathHelper.Multiply(a, b));

        try
        {
            Console.WriteLine("Divide: " + MathHelper.Divide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        
        b = 0;
        try
        {
            Console.WriteLine("Divide with b=0: " + MathHelper.Divide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

