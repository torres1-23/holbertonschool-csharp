using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
            double[] a = {1, 2};
            Console.WriteLine(VectorMath.Magnitude(a));
            double[] b = {100, 2, 3};
            Console.WriteLine(VectorMath.Magnitude(b));
            double[] c = {1, 2, 3, 4};
            Console.WriteLine(VectorMath.Magnitude(c));
    }
}
