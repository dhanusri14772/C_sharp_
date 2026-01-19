using System;
enum Borderside
{
    left,right,Top,bottom
}
class Ant
{
    static void Enumconversions()
    {
        Borderside side = Borderside.bottom;
        int value = (int)side; //enum-->int
        Console.WriteLine(value);
        Borderside side2 = (Borderside)2; //int-->enum
        Console.WriteLine(side2);
    }
    static void Main()
    {
        Enumconversions();
    }
}