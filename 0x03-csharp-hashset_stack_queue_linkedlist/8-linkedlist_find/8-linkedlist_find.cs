﻿using System;
using System.Collections.Generic;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int i = 0;
		foreach (int number in myLList)
		{
			if (value == number)
			{
				return i;
			}
			i++;
		}
		return -1;
	}
}
