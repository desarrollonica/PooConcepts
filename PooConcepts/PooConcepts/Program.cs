using PooConcepts;

Console.WriteLine("Conceptos de POO");
Console.WriteLine("----------------");

try
{
	Console.WriteLine(new Date(2024, 01, 05));
	Console.WriteLine(new Date(2024, 7, 25));
	Console.WriteLine(new Date(2024, 11, 12));
    Console.WriteLine(new Date(2024, 02, 29));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}
