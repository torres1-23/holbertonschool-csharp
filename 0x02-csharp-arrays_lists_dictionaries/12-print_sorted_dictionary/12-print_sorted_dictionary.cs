using System;
using System.Collections.Generic;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		var KeysList = new List<string>();
		foreach (string key in myDict.Keys)
		{
			KeysList.Add(key);
		}
		KeysList.Sort();
		foreach (string key in KeysList)
		{
			Console.WriteLine($"{key}: {myDict[key]}");
		}
	}
}
