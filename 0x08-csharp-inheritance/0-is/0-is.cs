using System;
using System.Collections.Generic;

/// <summary>Represents an Obj.</summary>
class Obj
{
    /// <summary>Checks if an object is of type int.</summary>
    /// <param name="obj">Object to check its type.</param>
    /// <returns>True if object is an int, otherwise False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
