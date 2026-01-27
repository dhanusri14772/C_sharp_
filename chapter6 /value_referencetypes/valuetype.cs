using System;
class valueType
{
    static void Main()
    {
        int a = 100; //value of a is 100 
        int b = a ;
        b = 29; //value of b alone becomes 29 , since they are of diff copies 
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}