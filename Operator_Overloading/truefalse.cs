using System;
struct Box
{
    public int Size;
    public static bool operator true(Box b)
        => b.Size > 0;
    public static bool operator false(Box b)
        => b.Size <= 0;
}
class Truefalse
{
    static void Main()
    {
        Box b = new Box { Size = 10 };

        if (b)
            Console.WriteLine("Box is valid");
    }
}
