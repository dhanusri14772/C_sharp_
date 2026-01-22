using System;
struct Score
{
    public int Value;
    public static bool operator <(Score a, Score b)
        => a.Value < b.Value;
    public static bool operator >(Score a, Score b)
        => a.Value > b.Value;
    public static bool operator <=(Score a, Score b)
        => a.Value <= b.Value;
    public static bool operator >=(Score a, Score b)
        => a.Value >= b.Value;
}
class Compoper
{
    static void Main()
    {
        Score s1 = new Score { Value = 60 };
        Score s2 = new Score { Value = 80 };
        Console.WriteLine(s1 < s2);
    }
}
