class Task2
{
    static void Main()
    {
        // gavaketot studentebis organzomilebiani masivi saxelebistvis da qulebistvis 2 saganshi
        string[] students = new string[3];
        int[,] grades = new int[3, 2]; // 3 students, 2 subjects

        // shevikvanot studentis saxeli
        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"sheikvanet studentis saxeli {i + 1}: ");
            students[i] = Console.ReadLine();
        }

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"\nchaweret studentis qula qimiasa da biologiashi {students[i]}:");
            Console.Write("qimiis qula: ");
            grades[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("biologiis qula : ");
            grades[i, 1] = int.Parse(Console.ReadLine());
        }

        // davabechdino studentis saxeli da misi shesabamisi qula sagnebis mixedvit
        Console.WriteLine("\nStudentebis shefaseba:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{students[i]}: qula qimiashi = {grades[i, 0]}, qula biologiashi = {grades[i, 1]}");
        }
    }
}