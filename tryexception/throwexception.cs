using System;
class Throwexception
{
    static void Withdraw(int amount)
    {
        if (amount > 1000)
            throw new Exception("Limit exceeded"); //throw exception 
        Console.WriteLine("Withdraw successful");
    }
    static void Main()
    {
        try
        {
            Withdraw(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
