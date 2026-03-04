namespace oopdemo2;


class Person {

    // Automatically Implemented one
    // Means we get something like int _age = 0;
    public int Age { get; set; } = 0;

    
    // public string Name { get; set; } = String.Empty;
    private string value = "Something";
    private string firstName = String.Empty;
    private string lastName = String.Empty;
    
    public string Name {
        get => firstName + " " + lastName;
        set {
            string[] parts = value.Split(" ");
            firstName = parts[0];
            lastName = parts[1];
        }
    }

    public Person(string name, int age)
    {
        Age = age;
        Name = name;
    }
}

class Program
{

    // static int Add(int a, int b)
    // {
    //     return a + b;
    // }

    // static float Add(int a, int b)
    // {
    //     return (float)((a + b));
    // }

    // static int Add(int a, int b, int c)
    // {
    //     return a + b + c;
    // }

    // static float Add(float a, float b)
    // {
    //     return a + b;
    // }

    static void Main(string[] args)
    {

        // object r1 = (float)Add(1, 2); // 3
        // int r2 = Add(1, 2, 3); // 6
        // float r3 = Add(1.0f, 1.5f);

        // Console.WriteLine(r1);
        // Console.WriteLine(r2);
        // Console.WriteLine(r3);
    
        Person p = new Person("Jeff", 32);

        Console.WriteLine(p.Name);

        p.Name = "Jeffrey Jeffington";

    
        Console.WriteLine(p.Name);
    }
}
