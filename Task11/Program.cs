using System;

public class Counter
{
   
    private static int Count = 0;

  
    public Counter()
    {
        Count++;
    }

    public static int GetCount()
    {
        return Count;
    }

    public static void ResetCount()
    {
        Count = 0;
    }
}

public class Program
{
    public static void Main()
    {
        
        Counter c1 = new Counter();
        Console.WriteLine($"Current count after creating c1: {Counter.GetCount()}"); 

        Counter c2 = new Counter();
        Console.WriteLine($"Current count after creating c2: {Counter.GetCount()}"); 

        
        Counter c3 = new Counter();
        Console.WriteLine($"Current count after creating c3: {Counter.GetCount()}"); 

        // Count-ის reset
        Counter.ResetCount();
        Console.WriteLine($"Count after reset: {Counter.GetCount()}"); 
    }
}
