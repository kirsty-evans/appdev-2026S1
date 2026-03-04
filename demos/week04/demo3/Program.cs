namespace demo3;

abstract class Furniture
{

    public abstract void Stack(Furniture furniture);

    public virtual bool CanBeStacked()
    {
        return false;
    }
    
}

class Chair : Furniture {

    public Furniture? Next { get; set; }
    
    public override void Stack(Furniture furniture)
    {
        if(Next == null)
        {
            Console.WriteLine("Stacked Furniture");
            Next = furniture;
        }
        else
        {
            Console.WriteLine("Unable to add to Chair");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Furniture f1 = new Furniture();
        Chair c1 = new Chair();
        Chair c2 = new Chair();
        Chair c3 = new Chair();
        f1.Stack(c2);
        f1.Stack(c3);
    }
}
