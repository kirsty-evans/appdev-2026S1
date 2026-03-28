namespace demo04;

// T is a type parameter
class Box<T> {

    public T Data { get; set; }

    public Box(T data)
    {
        Data = data;
    }
    
}


public class DynamicList<T> {

    public int Capacity { get; set; } = 4;
    public int Size { get; set; } = 0;
    T[] objects;

    public DynamicList() {
        objects = new T[Capacity];
    }

    public void Add(T value)
    {
        if(Size >= Capacity) {
            Capacity = Capacity * 2;
            T[] temp = new T[Capacity];
            for(int i = 0; i < objects.Length; i++) {
                temp[i] = objects[i];
            }

            objects = temp;
        }
    
        objects[Size] = value;
        Size++;
    }

    public T? Get(int index)
    {
        if(index < 0 || index > Size)
        {
            return default(T);
        }
        return objects[index];
    }
    
}


class Program
{
    static void Main(string[] args)
    {
        DynamicList<string> numbers = new DynamicList<string>();

        for(int i = 0; i < 10; i++) {
            numbers.Add((i+1) + "! str-version");
        }
        for(int i = 0; i < 10; i++) {
            string? v = numbers.Get(i);
            Console.WriteLine(v);
        }

    
    }
    // static void Main(string[] args)
    // {
    //     Box<string> box = new Box<string>("Hello Box!");

    //     Console.WriteLine(box.Data);
    
    //     Box<int> boxInt = new Box<int>(10);

    //     Console.WriteLine(boxInt.Data);
    // }
}
