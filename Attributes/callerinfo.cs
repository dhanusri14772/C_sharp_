using System;
using System.Runtime.CompilerServices;
class Callerinfo
{
    static void Log(
        string message,
        [CallerMemberName] string member = "", //compiler fills the name
        [CallerLineNumber] int line = 0) //compiler inserts line no.
    {
        Console.WriteLine($"{member} at line {line}: {message}");
    }
    static void Main()
    {
        Log("Something happened"); //caller passes only message
    }
}
