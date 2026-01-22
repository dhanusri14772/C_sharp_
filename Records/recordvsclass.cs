using System;
record R(int X); //record r created where value equality plays major role 
class C { public int X; } //  class with reference equality
class Recordclass
{
    static void Main()
    {
        var r1 = new R(5); 
        var r2 = new R(5);//values of r1 &r2 are same
        var c1 = new C { X = 5 };
        var c2 = new C { X = 5 }; //referneces = c1&c2 are diff
        Console.WriteLine(r1 == r2);          // true
        Console.WriteLine(c1 == c2);          // false
    }
}
