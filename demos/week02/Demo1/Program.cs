namespace Demo1;

class Program
{

    // x and y are parameters
    // return type which is `int`
    static int Add(int x, int y)
    {
        return x + y; // result of x+y which is 15
    }

    static void Main(string[] args)
    {
        //  5 and 10 are arguments
        //               x   y
        int result = Add(5, 10);
        Console.WriteLine(result);
    }
}
