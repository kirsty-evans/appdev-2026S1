// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

// checks for a command line argument and that it is a valid integer
if (args.Length > 0 && int.TryParse(args[0], out int number))
{
    int square = number * number;
    Console.WriteLine($"{square}");
}