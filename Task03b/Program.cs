int sum = 0;
int number;

Console.WriteLine("sheikvanet dadebiti ricxvi (uarkopiti ricxvi daasrulebs programas):");

// წავიკითხოთ პირველი რიცხვი
string input = Console.ReadLine();

// შევამოწმოთ არის თუ არა შეყვანილი მნიშვნელობა რიცხვი
while (int.TryParse(input, out number) && number >= 0)
{
    // დავამატოთ რიცხვი ჯამს
    sum += number;

    // წავიკითხოთ შემდეგი რიცხვი
    input = Console.ReadLine();
}

Console.WriteLine($"jami: {sum}");
