using System;
class Base
{
    protected internal int X = 10;
}
class Child : Base
{
    public void Show()
    {
        Console.WriteLine(X); 
    }
}
class Bro
{
    static void Main()
    {
        Base b = new Base();
        Console.WriteLine(b.X); 
    }
}
