using System;

class SpiceHound : Ninja
{
    public int CaloriesConsumed { get; private set; }

    public override bool IsFull
    {
        get { return CaloriesConsumed >= 1200; }
    }

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            CaloriesConsumed += item.Calories;
            ConsumptionHistory.Add(item);

            if (item is Food && ((Food)item).IsSpicy)
            {
                Console.WriteLine($"SpiceHound consumed {item.Name} and gained {item.Calories} calories.");
            }
            else
            {
                Console.WriteLine($"SpiceHound consumed {item.Name}.");
            }
        }
        else
        {
            Console.WriteLine("SpiceHound is full and cannot consume more.");
        }
    }
}
