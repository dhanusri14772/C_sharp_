using System;

class Box<T>
{
    public T Value;
}

class Program
{
    static void Main()
    {
        Box<int> b = new Box<int>();  // now T becomes int
        b.Value = 10;

        int x = b.Value; 
        Console.WriteLine(x);
    }
}
