using System;
using System.Runtime.CompilerServices;
class Callerargument
{
    static void Validate(
        bool condition,
        [CallerArgumentExpression("condition")] string? expr = null)
    {
        if (!condition)
            Console.WriteLine($"Validation failed: {expr}");
    }
    static void Main()
    {
        int x = 5;
        Validate(x > 10);
    }
}
