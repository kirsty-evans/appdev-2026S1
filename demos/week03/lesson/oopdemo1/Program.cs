using System.Runtime.ConstrainedExecution;

namespace oopdemo1;


// class Point {

//     public int X = 10;
//     public int Y = 20;
    
// }

class Cupcake // Cupcake is now a type!
{
    private bool delicious;
    private string name;

    public Cupcake(bool delicious, string name)
    {
        this.delicious = delicious; // parameter
        this.name = name;
        
    }

    public bool GetDelicious() {
        return delicious;
    }

    public string GetName()
    {
        return name;
    }

    public Cupcake GetSelf()
    {
        return this;
    }

    public void SetName(string cakeName)
    {
        name = cakeName;
    }
}

class Program
{

    static void Main(string[] args)
    {
     // What is happening with the assignment below?
     // Type   varName  =     (make_alloc   Uses the constructor): Allocation
        // Cupcake c2      =       new       Cupcake(true,
        //     "Chocolate Cupcake", null);

        // Cupcake c1      =       new       Cupcake(false,
        //     "Vanilla Cupcake", null);

        Cupcake c2 = new Cupcake(true, "Chocolate Cupcake");

        Cupcake c1 = new Cupcake(false, "Vanilla Cupcake");
        Cupcake clone = c1.GetSelf();

        Console.WriteLine(c1.GetName());
        Console.WriteLine(clone.GetName());
        Console.WriteLine("======");

        c1.SetName("Strawberry Cupcake");

        Console.WriteLine("======");
        Console.WriteLine(c1.GetName());
        Console.WriteLine(clone.GetName());
    }

    // static void Main(string[] args)
    // {

    //     int n = int.Parse(Console.ReadLine());

    //     for(int i = 0; i < n; i++) {
    //         Point p1 = new Point();
    //         Console.WriteLine(p1.X);
    //         Console.WriteLine(p1.Y);

    //         p1.X = 50;
    //         Console.WriteLine(p1.X);
    //         Console.WriteLine(p1.Y);
    //     }
    // }
}
