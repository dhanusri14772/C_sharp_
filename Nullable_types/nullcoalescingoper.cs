using System;
class Nullcoalescing
{
    static void Main()
    {
        int? score = null;
        int finalscore = score ?? 50; //if score exists then it gives the score or if its null , it gives us the value : 50 
        Console.WriteLine(finalscore);
    }
}