// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your mark: ");

string input = Console.ReadLine();
int mark = int.Parse(input);

if (mark >= 85)
{
    Console.WriteLine("A");
}
else if (mark >= 75)
{
    Console.WriteLine("B");
}
else if (mark >= 65)
{
    Console.WriteLine("C");
}
else if (mark >= 50)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}