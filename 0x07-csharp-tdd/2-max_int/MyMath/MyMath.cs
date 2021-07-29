using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Contains mathematical operations.</summary>
    public class Operations
    {
        /// <summary>Finds the maximun integer in a list</summary>
        /// <param name="nums">List of integers</param>
        /// <returns>Max integer in list</returns>
        public static int Max(List<int> nums)
        {
            int num = 0;
            if (nums.Count != 0)
            {
                nums.Sort();
                num = nums[nums.Count - 1];
            }
            return (num);
        }
    }
}
