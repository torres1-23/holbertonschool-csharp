using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size == 0)
		{
			Console.WriteLine("");
			return new List<int>();
		}
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		var MyList = new List<int>();
		for (int i = 0; i < size; i++)
		{
			MyList.Add(i);
		}
		Console.WriteLine(string.Join(", ", MyList));
		return MyList;
	}
}
