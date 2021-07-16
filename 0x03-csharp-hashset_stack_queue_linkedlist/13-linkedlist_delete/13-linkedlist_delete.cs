using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		int i = 0;
        LinkedListNode<int> head = myLList.First;
        for (; i < index && head.Next != null; i++)
		{
            head = head.Next;
		}
		if (i == index)
		{
        	myLList.Remove(head);
		}
	}
}
