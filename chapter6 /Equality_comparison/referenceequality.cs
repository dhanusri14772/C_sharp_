using System;
class Foo { public int X; }
class Referenceequality
{
    static void Main()
    {
        Foo f1 = new Foo { X = 5 };
        Foo f2 = new Foo { X = 5 };
        Console.WriteLine(f1 == f2);
        Foo f3 = f1;
        Console.WriteLine(f1 == f3);
    }
}