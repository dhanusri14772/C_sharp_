int x = 8;
foo(x);
Console.WriteLine(x); 

static void foo(int p)
{
    p = p + 1;
    Console.WriteLine(10); 
}
