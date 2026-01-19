using System;
[Flags]
enum Bordersides
{
    left = 1 , right = 2 , top = 4 , bottom = 8
}
class Enum
{
static void Flagsenum()
    {
        Bordersides sides = Bordersides.left | Bordersides.top;
        Console.WriteLine(sides);
    }
static void CheckFlag()
{
    Bordersides sides = Bordersides.left | Bordersides.top;

    bool hastop = (sides & Bordersides.top) != 0;
    Console.WriteLine(hastop);   // Output: True
}

static void Main()
    {
        Flagsenum();
        CheckFlag();
    }}