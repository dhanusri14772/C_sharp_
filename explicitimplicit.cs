using System;

class Program
{
    static void Main()
    {
        char[] vowels1 = { 'a', 'e', 'i', 'o', 'u' }; //explicit definition of variables

        int[,] rectangularmatrix =
        {
            {0,1,2},
            {3,4,5},
            {6,7,8}
        };

        int[][] jaggedmatrix =
        {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8,9}
        };

        var i = 3; //implicit declaration of variable
        var s = "sausage";

        var rectmatrix = new int[,]
        {
            {0,1,2},
            {3,4,5},
            {6,7,8}
        };

        var jaggedmat = new int[][]
        {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8,9}
        };

        var vowels2 = new[] { 'a', 'e', 'i', 'o', 'u' }; //implicit array typing
        var numbers = new[] { 1, 10000000000L };
        Console.WriteLine($"i = {i}, s = {s}");
        Console.WriteLine($"First vowel: {vowels2[0]}");
        Console.WriteLine($"Rect matrix [1,2]: {rectmatrix[1,2]}");
        Console.WriteLine($"Jagged matrix [2][3]: {jaggedmat[2][3]}");
        Console.WriteLine($"numbers type: {numbers.GetType()}");
    }
}
