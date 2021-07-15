using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		LinkedList<int> IntLList = new LinkedList<int>();
		if (size < 0)
		{
			return IntLList;
		}
		for (int i = 0; i < size; i++)
		{
			IntLList.AddLast(i);
		}
		Console.WriteLine(string.Join("\n", IntLList));
		return IntLList;
	}
}
