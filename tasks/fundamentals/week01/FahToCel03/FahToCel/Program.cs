if (args.Length > 0 && int.TryParse(args[0], out int F))
{
    // double for precision. 5.0 to force floating point division
    double C = (F - 32) * (5.0/9);
    Console.WriteLine($"{C}");
}

// Console.WriteLine("Convert your Fahrenheit to Celsius");




