using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		var ValueList = new List<int>();
		foreach (KeyValuePair<string, int> pair in myList)
		{
			ValueList.Add(pair.Value);
		}
		ValueList.Sort();
		foreach (KeyValuePair<string, int> pair in myList)
		{
			if (pair.Value == ValueList[ValueList.Count - 1])
			{
				return pair.Key;
			}
		}
		return "None";
	}
}
