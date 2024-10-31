using System;

class Program
{
    static void Main(string[] args)
    {
        // momxmareblisagan movitxovot mteli ricxvebis chawera
        Console.Write("gtxovt sheikvanot mteli ricxvebis masivi: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        int[] array = new int[5];

        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = int.Parse(inputArray[i].Trim());
        }

        // garedan movitxovot indeqsis chawera
        Console.Write("gtxovt sheikvanot indeqsi.: ");
        int index = int.Parse(Console.ReadLine());

        // davtvalot masivis da indeqsis shedegi
        int result = DigitSum(array, index);
        Console.WriteLine("jami: " + result);
    }

    public static int DigitSum(int[] array, int index)
    {
        // araswori monacemebi rom ar chaweros davadot validacia if it.
        // tu if-is pirobas acda davuwerot rom arasworia indeqsi da returnit shevwyvito
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("shekvanili indeqsi arasworia.");
            return 0;
        }

        int number = array[index];
        int sum = 0;

        // indeqsis shesabamisi elementismasivshi cifrebis jami
        while (number != 0)
        {
            sum += Math.Abs(number % 10); 
            number /= 10;
        }

        return sum;
    }
}