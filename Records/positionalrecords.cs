using System;
record point(int x,int y); //declaring record "point" where it defines properties via constructor parameters.
class Positionalrecords
{
    static void Main()
    {
        var i = new point(32,54); //creating object i 
        Console.WriteLine(i.x);
        Console.WriteLine(i.y);
    }
}