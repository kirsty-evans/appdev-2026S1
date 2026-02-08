// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string? input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    int square = number * number;
    Console.WriteLine($"{square}");
}