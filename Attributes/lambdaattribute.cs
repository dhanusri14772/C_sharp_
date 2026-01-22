using System;
using System.Diagnostics.CodeAnalysis;
class Lambdaattribute
{
    static void Main()
    {
        Func<string?, int> length =
            [return: NotNullIfNotNull("s")]
            (string? s) => s == null ? 0 : s.Length;//lambda 

        Console.WriteLine(length("hello,bonjour"));
    }
}
