using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] a = {1, 2};
        double[] b = {1, 2};
        b = VectorMath.Add(a, b);
        Console.WriteLine($"({b[0]}, {b[1]})");
        double[] c = {100, 2, 3};
        double[] d = {100, 2, 3};
        d = VectorMath.Add(c, d);
        Console.WriteLine($"({d[0]}, {d[1]}, {d[2]})");
        double[] e = {1, 2, 3, 4};
        e = VectorMath.Add(e, a);
        Console.WriteLine($"({e[0]}, {e[1]})");
    }
}
