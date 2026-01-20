using System;
struct S { public int X; }
class C { public int X; }
class Program
{
    static void Main()
    {
        S s1 = new S { X = 10 };
        S s2 = s1;
        s2.X = 20; //struct here copies the value
        C c1 = new C { X = 10 };
        C c2 = c1;
        c2.X = 20; //classs here copies the reference
        Console.WriteLine($"Struct: {s1.X}");
        Console.WriteLine($"Class: {c1.X}");
    }
}
