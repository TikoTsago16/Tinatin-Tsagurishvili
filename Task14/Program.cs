using System;

class InvalidCalculatorOperationException : Exception
{
    public int Status { get; }

    public InvalidCalculatorOperationException(string message, int status) : base(message)
    {
        Status = status;
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("sheikvanet pirveli ricxvi: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("sheikvanet meore ricxvi: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("sheikvanet operacia (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = Calculate(num1, num2, operation);
                Console.WriteLine($"shedegi: {result}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("shecdomaa, gtxovt sheikvanot validuri ricxvi.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("nulze gayopa sheudzlebelia.tavidan scadet.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("operacia arasworia, tavidan scadet.");
            }
            catch (InvalidCalculatorOperationException ex)
            {
                Console.WriteLine($"shecdoma {ex.Message} (statusi: {ex.Status})");
            }
        }
    }

    static double Calculate(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 == 0)
                    throw new DivideByZeroException();
                return num1 / num2;
            default:
                throw new InvalidCalculatorOperationException("momkhmareblis mier shekvanilia daushvebeli operacia.", 400);
        }
    }
}

