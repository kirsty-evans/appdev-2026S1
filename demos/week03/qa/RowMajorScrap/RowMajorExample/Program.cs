namespace RowMajorExample;

class Program
{

    static int Get(int[] array, int width, int x, int y) {
        int index = (y * width) + x;
        return array[(y * width) + x];
    }

    static void Main(string[] args)
    {
        // // 3 x 3
        // // 1 2 3
        // // 4 5 6
        // // 7 8 9
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // int v = Get(numbers, 3, 1, 1);
        // Console.WriteLine(v);

        // Division by 0 with Floating Points
        // 
        // double f = 0.0 / 0.0;
        // Console.WriteLine(f);
        // Console.WriteLine(double.IsNaN(f));
        
    }
}
