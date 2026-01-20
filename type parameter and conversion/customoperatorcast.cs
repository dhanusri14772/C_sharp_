using System;
class Meter
{
    public int value;
    public static explicit operator int(Meter m)
    {
        return m.value;
    }
}
class Customcast
{
    static void Main()
    {
        Meter m = new Meter {value = 5};
        int x = (int)m; //customcasting is done for meter "m"

        Console.WriteLine(x);
    }
}