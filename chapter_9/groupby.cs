using System;
using System.Collections.Generic;
using System.Linq;
public class Groupby
{
    public static void Main()
    {
        string[] names = {"tom","jay","harry","mary","karthi"};
        IEnumerable<IGrouping<int, string>> query = names.GroupBy(n => n.Length);
        foreach (IGrouping<int,string> grouping in query)
        {
            Console.Write("\r\nLength" + grouping.Key + ":");
            foreach (string name in grouping) Console.WriteLine(""+name);
        }
    }
}