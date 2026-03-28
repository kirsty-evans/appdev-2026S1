namespace demo2;

// At the top of the type hierarchy
public class PromotionalCard
{
    private string name;
    private double amount;


    public PromotionalCard(string name, double amount)
    {
        this.name = name;
        this.amount = amount;
    }

    public string GetName()
    {
        return name;
    }

    public double GetAmount()
    {
        return amount;
    }

    public void SetAmount(double amount)
    {
        this.amount = amount;
    }

    public virtual double ApplyDiscount(double currentAmount)
    {
        return currentAmount - amount;
    }

    public virtual bool IsValid()
    {   //        expression is evaluated first
        // then negation
        // if( ! <boolean expression> )
        // {
        //   
        // }
        //
        // 
        return amount > 0.0;
    }
}

class GiftCard : PromotionalCard
{
    public GiftCard(double amount): base("Gift Card", amount)
    {
        // NOOP
    }

    public override double ApplyDiscount(double currentAmount)
    {
        double amountDiff = currentAmount - base.GetAmount();

        if(amountDiff < 0)
        {
            base.SetAmount(Math.Abs(amountDiff));
            return 0.0;
        }
        else
        {
            return amountDiff;    
        }
    
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        PromotionalCard[] cards = new PromotionalCard[3] {
            new CoffeeCard(2),
            new CoffeeCard(1),
            new GiftCard(50),
        };
        


        for(int i = 0; i < 11; i++)
        {
            double cost = 6.80;
            for(int j = 0; j < cards.Length; j++)
            {
                PromotionalCard gc = cards[j];
                Console.WriteLine("Using: " + gc.GetName());
                double discounted = gc.ApplyDiscount(cost);
                Console.WriteLine("Discounted: " + discounted
                    + "\n");

                if(discounted < 0.0) {
                    break;
                }
                
            }
        }
        
    }
}
