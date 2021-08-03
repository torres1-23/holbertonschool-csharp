using System;

/// <summary>Represents a Shape.</summary>
class Shape
{
    /// <summary>Area of a shape.</summary>
    /// <exception cref="NotImplementedException">Area method is not implemented</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
