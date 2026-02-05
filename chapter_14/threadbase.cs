using System;
using System.Threading;
public class ThreadTest
{   
    bool _done;
    public static void Main()
    {
       ThreadTest tt = new ThreadTest();
       new Thread(tt.Go).Start();
       tt.Go(); 
    }
    void Go()
    {
        if (!_done) {_done = true; Console.WriteLine("Done");}
    }
}