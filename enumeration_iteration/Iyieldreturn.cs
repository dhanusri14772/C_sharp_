using System;
using System.Collections.Generic;
class Yieldreturn
{
    static IEnumerable<int> CountToThree()
    {
        yield return 1878; //return first value and pauses
        yield return 281; //resumes and returns next value 
        yield return 3658;
    }
    static void Main()
    {
        foreach (int n in CountToThree()) 
            Console.WriteLine(n);
    }
}
