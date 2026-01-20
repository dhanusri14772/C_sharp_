using System;
class BankAccount
{
    private int balance = 1000;
    public void ShowBalance()
    {
        Console.WriteLine(balance); // private member "balance" is accessed inside the class 
    }
}
class Program
{
    static void Main()
    {
        BankAccount b = new BankAccount();
        b.ShowBalance(); //directly balance cannot be called here.
    }
}
