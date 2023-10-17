using System;

class SweetTooth : Ninja
{
    public int CaloriesConsumed { get; private set; }

    public override bool IsFull
    {
        get { return CaloriesConsumed >= 1500; }
    }

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            CaloriesConsumed += item.Calories;
            ConsumptionHistory.Add(item);

            if (item is Drink)
            {
                Console.WriteLine($"SweetTooth consumed {item.Name} and gained {item.Calories} calories.");
            }
            else
            {
                Console.WriteLine($"SweetTooth consumed {item.Name}.");
            }
        }
        else
        {
            Console.WriteLine("SweetTooth is full and cannot consume more.");
        }
    }
}
