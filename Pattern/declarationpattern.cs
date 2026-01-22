using System;
class Brocode
{
    static void Main()
    {
        object x = 10;
        if (x is int i) //checks if x is int , then unboxes and store it as i
            Console.WriteLine(i + 5);
    }
}
