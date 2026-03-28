namespace demo03;

class Program
{
    static void Main(string[] args)
    {
        int capacity = 4;
        int size = 0;
        string[] lines = new string[capacity];

        string? line = Console.ReadLine(); 
        while(line != null)
        {
            if(size >= capacity) {
                capacity = capacity * 2;
                string[] temp = new string[capacity];
                for(int i = 0; i < lines.Length; i++) {
                    temp[i] = lines[i];
                }

                lines = temp;
            }
        
            lines[size] = line;
            size++;
            line = Console.ReadLine(); 
        }

        for(int i = 0; i < size; i++) {
            Console.WriteLine(lines[i]);
        }
    
    }
}
