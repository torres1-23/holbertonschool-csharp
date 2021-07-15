using System;
using System.Linq;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		if (n < 0 || n > myLList.Count)
		{
			return 0;
		}
		return myLList.ElementAt(n);
	}
}
