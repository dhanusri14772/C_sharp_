using System;
class valuetypePasstomethod
{
    static void change(int x) //method change
    {
        x = 100;
    }
    static void Main()
    {
        int x = 4678;
        change(x); //assigns & change value of a to 4678
        Console.WriteLine(x);
    }
}