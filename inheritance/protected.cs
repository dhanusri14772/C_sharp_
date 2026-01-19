using System;
class Account
{
    protected int balance = 1000;
}
class Savings : Account
{
    public void ShowBalance()
    {
        Console.WriteLine(balance);
    }
}
class Program
{
    static void Main()
    {
        Savings s = new Savings();
        s.ShowBalance();
    }
}
