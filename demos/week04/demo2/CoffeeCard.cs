namespace demo2;


class CoffeeCard : PromotionalCard
{
    // DaysLeft means DaysCounted - My mistake
    public int DaysLeft { get; set; }

    public int DaysForFreeCoffee { get; set; }

    private bool notUsed = true;

    public CoffeeCard(int freeCoffee) :
        base("CoffeeCard", 7.00){

        DaysLeft = 0;
        DaysForFreeCoffee = freeCoffee;
                
    }

    public override double ApplyDiscount(double currentAmount)
    {
        if(DaysLeft < DaysForFreeCoffee || !notUsed) {
            DaysLeft += 1;
            Console.WriteLine("Counting, no Discount");
            return currentAmount;
        } else {
            notUsed = false;
            Console.WriteLine("Discount, Free Coffee");
            double newAmount = currentAmount
                - base.GetAmount();

            return newAmount;
        }
    }
}

