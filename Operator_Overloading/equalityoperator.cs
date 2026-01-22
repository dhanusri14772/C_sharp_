using System;
struct point
{
    public int x,y;
    public static bool operator == (point a , point b)
           => a.x == b.x && a.y == b.y;
    public static bool operator !=(point a, point b)
           => !(a==b);
    public override bool Equals(object obj)
           => obj is point p && this == p;
    public override int GetHashCode()
           => HashCode.Combine(x,y);
}
class Operatoroverloading
{
    static void Main()
    {
        point p1 = new point{x=1,y=2};
        point p2 = new point{x=1 , y=2};
        Console.WriteLine(p1==p2);
    }
}