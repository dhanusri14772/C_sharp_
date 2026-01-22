using System;
struct number
{
    public int Value;
    public number(int v)
    {
        Value = v;
    }
    public static number operator -(number n)
    {
        return new number(-n.Value);
    }
}
class Unaryoperator 
{
    static void Main()
    {
        number n = new number(5);
        number m = -n;
        Console.WriteLine(m.Value);
    }
}
