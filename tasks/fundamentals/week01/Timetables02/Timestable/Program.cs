// See https://aka.ms/new-console-template for more information

<<<<<<< HEAD
Console.WriteLine("Hello World!");

=======
Console.WriteLine("Enter Number: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine(number * i);
    }
}
>>>>>>> 6593dc4 (finished week 01)

