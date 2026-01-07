static void Foo(out int p)
{
    p = 19;
}
int x;
Foo(out x);
Console.WriteLine(x); 
