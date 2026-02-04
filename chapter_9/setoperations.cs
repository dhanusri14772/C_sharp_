using System;
using System.Collections.Generic;
using System.Linq;
public class SEToperation
{
    public static void Main()
    {
        int[] seq1 = {1,2,3,4,5,6};
        int[] seq2 = {3,4,5,6,7,8};
        IEnumerable<int> concat = seq1.Concat(seq2);
        IEnumerable<int> union = seq1.Union (seq2);
        IEnumerable<int> common = seq1.Intersect(seq2);
        IEnumerable<int> diff = seq1.Except(seq2);
        Console.WriteLine("union:" + string.Join(",",union));
        Console.WriteLine("Intersection:"+string.Join(",",common));
        Console.WriteLine("difference (except):"+string.Join(",",diff));
    }
}