// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digit your note: ");
var readNote = Console.ReadLine();
var note = int.Parse(readNote);

// if / else

if (note >= 70)
{
    Console.WriteLine("Approval");
}
else if (note >= 40)
{
    Console.WriteLine("Recuperation");
}
else
{
    Console.WriteLine("Preapproval");
}

// switch / case
Console.WriteLine("Welcome to company x");

Console.WriteLine("Digit 1 - Contraction to plan");
Console.WriteLine("Digit 2 - FAQ");
Console.WriteLine("Digit 3 - Reclamation");
Console.WriteLine("Digit 4 - Duplicate ticket");

var option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
    {
        Console.WriteLine("Information to plan.");
        break;
    }
    case 2:
    {
        Console.WriteLine("Answer to question.");
        break;
    }
    case 3:
    {
        Console.WriteLine("Talk do reclamation.");
        break;
    }
    case 4:
    {
        Console.WriteLine("Verify your e-mail.");
        break;
    }
    default:
    {
        Console.WriteLine("Option not found.");
        break;
    }
}