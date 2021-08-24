using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] a = {1, 2};
        double b = 2;
        a = VectorMath.Multiply(a, b);
        Console.WriteLine($"({a[0]}, {a[1]})");
        double[] c = {100, 2, 3};
        a = VectorMath.Multiply(c, b);
        Console.WriteLine($"({a[0]}, {a[1]}, {a[2]})");
        double[] e = {1, 2, 3, 4};
        e = VectorMath.Multiply(e, b);
        Console.WriteLine($"({e[0]}, {e[1]})");
    }
}
