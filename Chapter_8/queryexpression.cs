using System;
using System.Collections.Generic;
using System.Linq;
public class Queryexpression
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        IEnumerable<string> query = 
            from n in names
            where n.Contains ("a")    
            orderby n.Length           
            select n.ToUpper();        
        foreach (string name in query) Console.WriteLine (name);

    }
}