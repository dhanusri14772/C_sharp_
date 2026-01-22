using System;
class methodTuple
{
    static (int Quotient, int Remainder) Divide(int x, int y) //method divide returns tuple
    {
        return (x / y, x % y);
    }
    static void Main()
    {
        var result = Divide(10, 3); //result here becomes tuple with the method "divide"
        Console.WriteLine(result.Quotient);
        Console.WriteLine(result.Remainder);
    }
}
