using System;
using System.Collections.Generic;

/// <summary>Represents Mathematical Operations with Vectors.</summary>
class VectorMath
{
    /// <summary>Adds two vectors.</summary>
    /// <param name="vector1">Vector 1 to add.</param>
    /// <param name="vector2">Vector 2 to add.</param>
    /// <returns>Result vector or -1 if op is not possible.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] result = {0, 0};
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }
            return result;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] result = {0, 0, 0};
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }
            return result;
        }
        return new double[] {-1, -1};
    }
}
