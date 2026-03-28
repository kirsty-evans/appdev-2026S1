namespace SlidesDemo2;

class Program
{
    //
    // 
    // 
    static void PrintArrayWith() {
        for(int i = 0; i < numbers1.Length; i++)
        {
            for(int j = 0; j < numbers1[i].Length; j++)
            {
                Console.WriteLine(numbers1[i][j]);
            }
            
        }
    }

    static void Main(string[] args)
    {
        int[][] numbers1 = new int[3][];
        numbers1[0] = new int[3];
        numbers1[1] = new int[5];
        numbers1[2] = new int[1];

        // int[][] numbers2 = {
        //     new int[]{1, 2, 3},
        //     new int[]{4, 5, 6},
        //     new int[]{7, 8, 9}
        // };
        // int[][].Length // Does not work

        int len = numbers1.Count();

        int counter = 1;
        // Outer Loop: Each Row
        for(int i = 0; i < numbers1.Length; i++)
        {
            for(int j = 0; j < numbers1[i].Length; j++)
            {
                numbers1[i][j] = counter;
                counter++;
                // Console.WriteLine(numbers1[i][j]);
                
            }
            
        }

        //Outputting
        for(int i = 0; i < numbers1.Length; i++)
        {
            for(int j = 0; j < numbers1[i].Length; j++)
            {
                Console.WriteLine(numbers1[i][j]);
            }
            
        }
    
    }
}
