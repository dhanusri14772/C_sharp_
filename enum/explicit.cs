using System;
enum Borderside
{
    left,right,Top,bottom
}
class Program
{
    static void Explicitonly()
    {
        Borderside side = Borderside.left;
        int x = (int)side;
        Console.WriteLine(x);
    }
    static void Main()
    {
        Explicitonly();
    }
}