
class Program
{
    static void Main()
    {
        
        string[] students = new string[3];

        Console.WriteLine("Enter the names of 3 students:");

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            students[i] = Console.ReadLine();
        }

        Console.WriteLine("\nList of Students:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}