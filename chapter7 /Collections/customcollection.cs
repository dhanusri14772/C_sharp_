using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
public class Customcollection
{
    public static void Main()
    {
        var zoo = new AnimalCollection();
        zoo.Add("Lion");
        zoo.Add("Tiger");
        zoo[1] = "Bengal Tiger"; // Triggers SetItem
        zoo.RemoveAt(0);         // Triggers RemoveItem
    }
}
public class AnimalCollection : Collection<string>
{
    protected override void InsertItem(int index, string item)
    {
        Console.WriteLine($"Adding: {item}"); //custom logic 
        base.InsertItem(index, item);
    }
    protected override void SetItem(int index, string item)
    {
        Console.WriteLine($"Changing {this[index]} to {item}");
        base.SetItem(index, item);
    }
    protected override void RemoveItem(int index)
    {
        Console.WriteLine($"Removing: {this[index]}");
        base.RemoveItem(index);
    }
    protected override void ClearItems()
    {
        Console.WriteLine("Clearing the whole zoo!");
        base.ClearItems();
    }
}