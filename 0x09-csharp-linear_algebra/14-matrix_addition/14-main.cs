using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[,] a = { { 1, 2 }, { 3, 4 } };
        double[,] b = { { 1, 2 }, { 3, 4 } };
        a = MatrixMath.Add(a, b);
        Console.WriteLine($"({a[0,0]}, {a[0,1]})");
        Console.WriteLine($"({a[1,0]}, {a[1,1]})");
    }
}
