namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // datatype   varname   operator (=)   value(literal)
            int        x          =            10;
            int        y          =            20;


            int[]     numbers     =          {10, 60, 89, 23};

            // numbers actually is assigned to an address
            //    Example 0x1000
            //
            //


            // 680 +   (2 * sizeof(int))
            int        value       =           numbers[2];

            int result = x + y + value;
            Console.WriteLine(result);

            string example = "The Number Is: " + result;

            Console.WriteLine(example);

            
        
    
    }
}
