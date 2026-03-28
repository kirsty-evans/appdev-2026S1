namespace demo1;


class Cat {

    private int age;
    public string Name { get; set; }

    public Cat(string name)
    {
        age = 1;
        Name = name;
    }

    public int GetAge()
    {
        return age;
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine("Meow");
    }
    
}


class Lion : Cat {

    public Lion(string name) : base(name) {}

    public override void MakeNoise()
    {
        
        Console.WriteLine("ROAR!!!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        //Lion is also Cat
        Lion lion = new Lion("Lion");

        Console.WriteLine(lion.Name);
        Console.WriteLine(lion.GetAge());
        
        lion.MakeNoise();        
    
    }
}
