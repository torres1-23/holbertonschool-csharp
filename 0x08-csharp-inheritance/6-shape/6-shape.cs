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

/// <summary>Represents a Rectangle.</summary>
class Rectangle: Shape
{
    private int width;
    private int height;
    /// <summary>Gets or sets the name.</summary>
    /// <exception cref="ArgumentException">If value is negative</exception>
    public int Width
    {
        get {return (width);}
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    ///<summary>Gets or sets height</summary>
    /// <exception cref="ArgumentException">If value is negative</exception>
    public int Height
    {
        get {return (height);}
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
}
