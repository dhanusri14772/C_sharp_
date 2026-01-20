using System;
interface IPrintable
{
    void Print();
}
struct Invoice : IPrintable
{
    public int Amount;

    public void Print()  //iprintable has print()
    {
        Console.WriteLine($"Invoice Amount: {Amount}");
    }
}
class Program
{
    static void Main()
    {
        Invoice inv = new Invoice { Amount = 500 };
        inv.Print();
    }
}
