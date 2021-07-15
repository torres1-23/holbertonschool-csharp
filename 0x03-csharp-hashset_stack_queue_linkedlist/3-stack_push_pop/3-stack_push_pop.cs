using System;
using System.Collections.Generic;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		int size = aStack.Count;
		bool IsIn = aStack.Contains(search);
		Console.WriteLine($"Number of items: {size}");
		if (size == 0)
		{
			Console.WriteLine("Stack is empty");
		}
		else
		{
			Console.WriteLine($"Top item: {aStack.Peek()}");
		}
		Console.WriteLine($"Stack contains \"{search}\": {IsIn}");
		if (IsIn == true)
		{
			while (aStack.Pop() != search)
			{
				continue;
			}
		}
		aStack.Push(newItem);
		return aStack;
	}
}
