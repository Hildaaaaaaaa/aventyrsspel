// See https://aka.ms/new-console-template for more information



Console.WriteLine("Du vaknar.");
Console.WriteLine("Vad heter du?");
Console.WriteLine("Skriv ditt namn nedan.");

String du = Console.ReadLine();

Console.WriteLine("Välkommen " + du);

Console.WriteLine("------------------------");

Console.ReadLine();

Console.WriteLine("Du står vid en väggren, vill du gå höger eller vänster?");
Console.WriteLine("1) Höger");
Console.WriteLine("2) Vänster");


string vägval = Console.ReadLine();

if (vägval == "1")
{
    Console.WriteLine("Du går Höger");
    Console.ReadLine();



}
if (vägval == "2")
{
    Console.WriteLine("Du går Vänster");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Skärp dig " + du + " Välj 1 eller 2 !");

    Console.WriteLine("1) Höger");
    Console.WriteLine("2) Vänster");


    Console.ReadLine();
}

Console.ReadLine();