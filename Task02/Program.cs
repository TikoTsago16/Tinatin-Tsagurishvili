

Random random = new();
int randomNumber = random.Next(1, 10);
int maxTries = 3;

for(int i = 1; i <= maxTries; i++)
{
    Console.WriteLine("Input Number");
    string input = Console.ReadLine();
    int inputNum = int.Parse(input); //convert to int

    if (randomNumber == inputNum)
    {
        Console.WriteLine("You Guessed the number");
        break;
    }
    else if (i == maxTries)
    {
        Console.WriteLine("Game Over");
        break;
    }
        
    Console.WriteLine("You have: "+(maxTries - i)+" Tries Left");
}