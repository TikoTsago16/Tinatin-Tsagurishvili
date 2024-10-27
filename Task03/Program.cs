
Console.Write("Enter a number from 1 to 7: ");

string input = Console.ReadLine();


if (int.TryParse(input, out int dayNumber))

{

  
    switch (dayNumber)

    {

        case 1:

            Console.WriteLine("orshabati");

            break;

        case 2:

            Console.WriteLine("samshabati");

            break;

        case 3:

            Console.WriteLine("otxshabati");

            break;

        case 4:

            Console.WriteLine("xutshabati");

            break;

        case 5:

            Console.WriteLine("paraskevi");

            break;

        case 6:

            Console.WriteLine("shabati");

            break;

        case 7:

            Console.WriteLine("kvira");

            break;

        default:

            Console.WriteLine("Invalid digit. Please try again from 1 to 7");

            break;
    }
}

   


