using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		int sum = 0;
        List<int> NoDupList = myList;
        NoDupList.Sort();
        for (int i = 0; i < NoDupList.Count; i++)
        {
            if (i == 0 || NoDupList[i] != NoDupList[i - 1])
			{
                sum += NoDupList[i];
			}
        }
        return sum;
	}
}
