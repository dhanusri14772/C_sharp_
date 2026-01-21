using System;
class Nullcoalescingassign
{
    static void Main()
    {
        int? surf = null;
        surf ??= 127849;
        Console.WriteLine(surf);
    }
}