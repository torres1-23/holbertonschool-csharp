using System;
using System.Collections.Generic;

/// <summary>Represents Mathematical Operations with Vectors.</summary>
class VectorMath
{
    /// <summary>Computesproduct of vector and scalar.</summary>
    /// <param name="vector">Vector to multiply.</param>
    /// <param name="scalar">Scalar to multiply</param>
    /// <returns>Resulting vector if it is a 3D or 2D, -1 otherwise.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
         if (vector.Length == 2)
        {
            double[] result = {0, 0};
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
            return result;
        }
        else if (vector.Length == 3)
        {
            double[] result = {0, 0, 0};
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
            return result;
        }
        return new double[] {-1, -1};
    }
}
