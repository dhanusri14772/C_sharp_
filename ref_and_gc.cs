using System;
using System.Text;
StringBuilder ref1 = new StringBuilder ("object1");
Console.WriteLine (ref1);
StringBuilder ref2 = new StringBuilder ("object2"); // ref1 is now eligible for GC.
StringBuilder ref3 = ref2; //not eligible to gc
Console.WriteLine (ref3); 