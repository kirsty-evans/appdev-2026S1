namespace FindCommon;

class Program
{
    // Query
    static int[] FindCommon(int[] a, int[] b)
    {
        
        int max = a.Length;
        if(max < b.Length)
        {
            max = b.Length;
        }
        
        int[] common = new int[max];
        int index = 0;

        for(int i = 0; i < a.Length; i++) {
            int v = a[i];

            for(int j = 0; j < b.Length; j++) {
                if(v == b[j]) {
                    common[index] = v;
                    index++;
                }
            }
        }

        
        int[] resize = new int[index];

        for(int i = 0; i < resize.Length; i++)
        {
            resize[i] = common[i];
        }

        return resize;
    }

    // Command
    static void PrintArray(int[] values)
    {
        Console.Write("[");
        for(int i = 0; i < values.Length; i++)
        {
            Console.Write(values[i] + " ,");
        }
        Console.WriteLine("]");
    }

    static void Main(string[] args)
    {
        int[] a1 = { 1, 2, 3, 4, 5};
        int[] b1 = { 1, 5, 10, 20, 30};

        int[] result1 = FindCommon(a1, b1);
        PrintArray(result1);
        //Output [1, 5]

        PrintArray(
            FindCommon(new int[]{1, 2, 3}, new int[]{1, 3, 2}));
        //Output 1, 2, 3

        
        PrintArray(
            FindCommon(new int[]{1, 2, 3}, new int[]{}));
        //Output []

        PrintArray(FindCommon(new int[]{90, -1, 45}, new int[]{-1, 40, 91}));
        //Output [-1]
    }
}
