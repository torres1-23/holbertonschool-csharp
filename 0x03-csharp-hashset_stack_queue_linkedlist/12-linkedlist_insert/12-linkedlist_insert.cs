using System;
using System.Linq;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
        LinkedListNode<int> head = myLList.First;
		if (head == null)
		{
			myLList.AddFirst(n);
			return myLList.First;
		}
		while (head.Next != null)
		{
			if (head.Value < n)
			{
				head = head.Next;
			}
			else
			{
				myLList.AddBefore(head, n);
				return myLList.Find(n);
			}
		}
		myLList.AddLast(n);
		return myLList.Last;
	}
}
