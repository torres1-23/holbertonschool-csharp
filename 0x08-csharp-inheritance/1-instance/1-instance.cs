using System;
using System.Collections.Generic;

/// <summary>Represents an Obj.</summary>
class Obj
{
    /// <summary>Checks if an object is an instance or derived of Array class.</summary>
    /// <param name="obj">Object to check.</param>
    /// <returns>True if object is an instance of Array, otherwise False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
