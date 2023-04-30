// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digit your note: ");
var readNote = Console.ReadLine();
var note = int.Parse(readNote);

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