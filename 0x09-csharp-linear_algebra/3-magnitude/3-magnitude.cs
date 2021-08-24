using System;
using System.Collections.Generic;

/// <summary>Represents Mathematical Operations with Vectors.</summary>
class VectorMath
{
    /// <summary>Computes Magnitud of a vector.</summary>
    /// <param name="vector">Vecto to calculate its magnitude.</param>
    /// <returns>Magnitude of vector if it is a 3D or 2D, -1 otherwise.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
        }
        else if (vector.Length == 3)
        {
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
        }
        return -1;
    }
}
