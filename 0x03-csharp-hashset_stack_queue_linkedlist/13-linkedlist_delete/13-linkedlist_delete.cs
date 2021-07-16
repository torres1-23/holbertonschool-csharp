using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
        LinkedListNode<int> head = myLList.First;
        for (int i = 0; i < index; i++)
		{
            head = head.Next;
			if (head == null)
			{
				return;
			}
		}
        myLList.Remove(head);
	}
}
