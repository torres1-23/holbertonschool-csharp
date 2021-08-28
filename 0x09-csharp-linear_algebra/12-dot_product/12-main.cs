using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] a = {1, 2};
        double[] b = {1, 2};
        double d = VectorMath.DotProduct(a, b);
        Console.WriteLine(d);
        double[] c = {100, 2, 3};
        d = VectorMath.DotProduct(c, c);
        Console.WriteLine(d);
        d = VectorMath.DotProduct(a, c);
        Console.WriteLine(d);
        double[] e = {1, 2, 3, 4};
        d = VectorMath.DotProduct(e, b);
        Console.WriteLine(d);
    }
}
