using System;

class LowBalanceException : Exception
{
    public LowBalanceException(string msg) : base(msg) { }
}
class CustomException
{
    static void Pay(int balance)
    {
        if (balance < 500)
            throw new LowBalanceException("Low balance");
    }
    static void Main()
    {
        try
        {
            Pay(200);
        }
        catch (LowBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
