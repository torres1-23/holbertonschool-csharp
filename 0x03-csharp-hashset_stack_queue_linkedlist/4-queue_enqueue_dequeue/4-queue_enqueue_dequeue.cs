using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		int size = aQueue.Count;
		bool IsIn = aQueue.Contains(search);
		Console.WriteLine($"Number of items: {size}");
		if (size == 0)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			Console.WriteLine($"First item: {aQueue.Peek()}");
		}
		aQueue.Enqueue(newItem);
		Console.WriteLine($"Queue contains \"{search}\": {IsIn}");
		if (IsIn == true)
		{
			while (aQueue.Dequeue() != search)
			{
				continue;
			}
		}
		return aQueue;
	}
}
