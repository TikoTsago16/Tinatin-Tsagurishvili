int sum = 0;
int number;

Console.WriteLine("sheikvanet dadebiti ricxvebi (uarkopiti ricxvis sheyvanis shemtxvevashi programa daasrulebs mushaobas):");

string input = Console.ReadLine();

while (int.TryParse(input,out number) && number >= 0)
{
    sum += number;

    input = Console.ReadLine();
}
Console.WriteLine($"jami: {sum}");
