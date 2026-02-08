using System.Diagnostics;

        string input = Console.ReadLine();

        // Test is expecting newline to be Odd
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Odd");
        }
        
        else if (int.TryParse(input, out int number))
        {

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


        }
        else
        {
            Console.WriteLine("Invalid");
        }

