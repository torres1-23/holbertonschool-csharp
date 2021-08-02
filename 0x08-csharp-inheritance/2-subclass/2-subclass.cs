using System;
using System.Collections.Generic;

/// <summary>Represents an Obj.</summary>
class Obj
{
    /// <summary>Checks if an object is an instance or derived of Array class.</summary>
    /// <param name="derivedType">Object to check.</param>
    /// <param name="baseType">Class to compare.</param>
    /// <returns>True if object is an instance of Array, otherwise False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
