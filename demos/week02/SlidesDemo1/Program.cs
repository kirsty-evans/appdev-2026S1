namespace SlidesDemo1;

class Program
{

    static void PrintArray(int[] numbers)
    {

        // for(int i = 0; i < numbers.Length; i++)
        // {
        //     int v = numbers[i];
        //     Console.WriteLine(v);
        // }
        //

        // While Loop equivalent
        int i = 0;
        while(i < numbers.Length)
        {
            int v = numbers[i];
            Console.WriteLine(v);

            i++;
        }
    }

    static void Main(string[] args)
    {
        // int[] numbers = new int[5];

        // // Assigning each element inside
        // // this array
        // numbers[0] = 10;
        // numbers[1] = 20;
        // numbers[2] = 30;
        // numbers[3] = 40;
        // numbers[4] = 50;

        // // What happens?
        // numbers[5] = 100;
        
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        int[] numbers2 = { 50, 10, 22, 80, 90, 12 };

        PrintArray(numbers2);
        
        
    }

    
}
