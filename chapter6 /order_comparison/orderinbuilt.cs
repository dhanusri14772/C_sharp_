using System;
class Builtintype
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a < b);
        Console.WriteLine(a.CompareTo(b)); //a is compared with b , where 5 is lesser than b-10 , thus returns -1
        Console.WriteLine(b.CompareTo(a)); //b is greater than a , thus returns +1
    }
}
