Console.Write("sheikvanet ricxvi: ");
string input = Console.ReadLine();

// შევამოწმოთ არის თუ არა შეყვანილი მნიშვნელობა რიცხვი
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"\ngamrvlebis cxrili {number}:");
    Console.WriteLine("-------------------------");

    // for ციკლით გამოვიტანოთ გამრავლების ცხრილი 1-დან 10-მდე
    for (int i = 1; i <= 10; i++)
    {
        int result = number * i;
        Console.WriteLine($"{number} x {i} = {result}");
    }

    Console.WriteLine("-------------------------");
}
else
{
    Console.WriteLine("gtxovt sheikvanot mxolod ricxvi!");
}

