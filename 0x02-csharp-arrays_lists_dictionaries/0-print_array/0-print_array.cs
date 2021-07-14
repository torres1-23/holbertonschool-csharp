using System;

class Array
{
	 public static int[] CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		int[] MyArray = new int[size];
		if (size == 0)
		{
			Console.WriteLine("");
			return MyArray;
		}
		for (int i = 0; i < size; i++)
		{
			MyArray[i] = i;
		}
		Console.WriteLine(string.Join(", ", MyArray));
		return MyArray;
	}
}
