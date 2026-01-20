using System ;
class Contravariance
{
    static void Main()
    {
        Action<object> obj = o => Console.WriteLine(o);
        Action<string> str = obj; //contravariance object-->string  
        str("csharp is shaping me indeed!");
    }
}