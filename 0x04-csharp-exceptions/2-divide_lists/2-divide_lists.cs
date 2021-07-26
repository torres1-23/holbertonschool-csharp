using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> divList = new List<int>();
        int div = 0;
        for(int i = 0; i < listLength; i++)
        {
            try
            {
                div = list1[i]/list2[i];
                divList.Add(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                divList.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            
        }
        return divList;
    }
}
