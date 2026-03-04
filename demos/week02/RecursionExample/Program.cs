namespace RecursionExample;

// While it was called RecursionExample, it isn't exactly
// Recursion
class Program
{

    static void PrintArray(int[] values)
    {
        Console.Write("[");
        for(int i = 0; i < values.Length; i++)
        {
            Console.Write(values[i] + " ,");
        }
        Console.WriteLine("]");
    }
    //array = 0x1000
    static void ChangeC(int[] array) {
        array = new int[10]; //We just set it to a new address with a new allocation
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * 10;
        }
    }
    
    static void PrintB(int[] array) {
        ChangeC(array);
        PrintArray(array);
    }

    static void PrintA(int[] array) {
        PrintArray(array);
        PrintB(array);
    }

    // This is recursion!
    static void CountdownWithoutLoop(int n)
    {
        if(n <= 0) {
            return;
        }
        Console.WriteLine(n);
        CountdownWithoutLoop(n-1);
    }

    static void Main(string[] args)
    {
        CountdownWithoutLoop(10);
    }
}
