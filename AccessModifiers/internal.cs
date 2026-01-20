using System;
internal class Test
{
    public void Show()
    {
        Console.WriteLine("internally affected peoples often suffer in silence");
    }
}
class Pro
{
    static void Main()
    {
        Test t = new Test(); 
        t.Show();
    }
}
