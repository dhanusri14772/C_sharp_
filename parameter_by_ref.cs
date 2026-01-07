int x = 8;
Foo(ref x);
Console.WriteLine(x); 
static void Foo(ref int p)
{
    p = p + 1;
}
