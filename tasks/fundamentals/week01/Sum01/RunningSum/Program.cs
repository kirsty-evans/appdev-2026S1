// See https://aka.ms/new-console-template for more information
// Console.WriteLine("This program will maintain a running sum until there is no more data.\n");

int runningSum = 0;
string? input;

while (true) {

    Console.WriteLine("Enter a number: ");
    input = Console.ReadLine();


    // will end the program is input is empty
    if (string.IsNullOrEmpty(input)) {
            break;
        }

    // checks input is a valid integer
    // if so, it saves it to 'number'
    if (int.TryParse(input, out int number))
        {
            runningSum += number;
        }

    }

Console.WriteLine($"\nThe total is: {runningSum}");

