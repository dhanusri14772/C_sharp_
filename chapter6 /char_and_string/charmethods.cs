using System;
using System.Globalization;
class Pro
{
    static void Main()
    {
        char c = 'i';
        Console.WriteLine(char.ToUpper(c));              // culture-sensitive
        Console.WriteLine(char.ToUpperInvariant(c));     // culture-invariant
        Console.WriteLine(char.IsLetter('A'));           // says True/false
        Console.WriteLine(char.IsDigit('o'));            
        Console.WriteLine(char.IsWhiteSpace('\t'));     
    }
}
