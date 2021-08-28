using System;
using System.Collections.Generic;

/// <summary>Represents Mathematical Operations with Vectors.</summary>
class VectorMath
{
    /// <summary>Computes product of vector and scalar.</summary>
    /// <param name="vector1">Vector to multiply.</param>
    /// <param name="vector2">Vector to multiply</param>
    /// <returns>Resulting scalar if operation is possible, -1 otherwise.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dot = -1;

        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            dot = 0;
            for (int i = 0; i < vector1.Length; i++)
                dot += (vector1[i] * vector2[i]);
        }
        return (dot);
    }
}
