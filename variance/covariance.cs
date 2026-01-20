using System;
using System.Collections.Generic;
class Covariance
{
    static void Main()
    {
        IEnumerable<string> names = new List<string> {"dhanu" , "khadija" , "anwer" , "nawf" , "josh" , "prathi" , "asii" , "prathi"};
        IEnumerable<object> obj = names; //covariance takes place where the innner realted generic type is been cov to "obj"

        foreach (object o in obj)
             Console.WriteLine(o);
    }
}