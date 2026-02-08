// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

if (args.Length > 0 && int.TryParse(args[0], out int number))
{
    int square = number * number;
    Console.WriteLine($"{square}");
}