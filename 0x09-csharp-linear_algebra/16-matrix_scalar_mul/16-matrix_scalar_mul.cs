using System;
using System.Collections.Generic;

/// <summary>Represents Mathematical Operations with matrices.</summary>
class MatrixMath
{
    /// <summary>Computes multiplication of matrix and scalar.</summary>
    /// <param name="matrix">Matrix to multiply.</param>
    /// <param name="scalar">Scalar to multiply.</param>
    /// <returns>Resulting matrix if operation is possible, -1 otherwise.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] bad = new double[,] {{-1}};
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);
        double[,] result;

        if (height == 2 && width == 2)
                result = new double[2, 2];
        else if (height == 3 && width == 3)
                result = new double[3, 3];
        else
            return (bad);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return (result);
    }
}
