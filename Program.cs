using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        SweetTooth sweetTooth = new SweetTooth();
        SpiceHound spiceHound = new SpiceHound();

        Food spicyFood = new Food("Spicy Curry", 500, true, false);
        Food sweetFood = new Food("Chocolate Bar", 300, false, true);
        Drink soda = new Drink("Soda", 150, false, true);

        sweetTooth.Consume(sweetFood);
        spiceHound.Consume(spicyFood);
        sweetTooth.Consume(soda);

        Console.WriteLine("SweetTooth's Consumption History:");
        foreach (var item in sweetTooth.ConsumptionHistory)
        {
            Console.WriteLine(item.GetInfo());
        }

        Console.WriteLine("\nSpiceHound's Consumption History:");
        foreach (var item in spiceHound.ConsumptionHistory)
        {
            Console.WriteLine(item.GetInfo());
        }
    }
}
