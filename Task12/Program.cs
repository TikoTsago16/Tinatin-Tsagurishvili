using System;
using System.Collections.Generic;

public class Box<T>
{
   
    private T value;

    
    public void SetValue(T value)
    {
        this.value = value;
    }

    
    public T GetValue()
    {
        return value;
    }
}

public static class Utility
{
    
    public static int GetListCount<T>(List<T> list)
    {
        return list.Count;
    }
}

class Program
{
    static void Main()
    {
       
        Box<int> intBox = new Box<int>();
        intBox.SetValue(10);
        Console.WriteLine("Stored value in intBox: " + intBox.GetValue());

        
        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("gamarjoba grendal!");
        Console.WriteLine("Stored value in stringBox: " + stringBox.GetValue());

       
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Count of elements in intList: " + Utility.GetListCount(intList));

        
        List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };
        Console.WriteLine("Count of elements in stringList: " + Utility.GetListCount(stringList));
    }
}
