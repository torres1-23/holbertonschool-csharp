using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		var DivList = new List<bool>();
		foreach (int number in myList)
		{
			if (number % 2 == 0)
			{
				DivList.Add(true);
			}
			else
			{
				DivList.Add(false);
			}
		}
		return DivList;
	}
}
