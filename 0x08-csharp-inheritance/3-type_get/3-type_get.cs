using System;
using System.Reflection;

/// <summary>Represents an Obj.</summary>
class Obj
{
    /// <summary>Prints the names of the available properties and methods of an object.</summary>
    /// <param name="myObj">Object to print its properties.</param>
    public static void Print(object myObj)
    {
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (var property in myObj.GetType().GetProperties())
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (var method in myObj.GetType().GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
