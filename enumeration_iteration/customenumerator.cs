using System;
using System.Collections;
class Counter : IEnumerable, IEnumerator
{
    int current = 0;
    public IEnumerator GetEnumerator()
    {
        return this;
    }
    public bool MoveNext()
    {
        current++;
        return current <= 3;
    }
    public object Current => current;
    public void Reset()
    {
        current = 0;
    }
}
class Custom
{
    static void Main()
    {
        Counter c = new Counter();
        foreach (int n in c)
            Console.WriteLine(n);
    }
}
