using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>Contains operations performed on text.</summary>
    public class Str
    {
        /// <summary>Search the first non-repeating character of a string.</summary>
        /// <param name="s">String to check.</param>
        /// <returns>Index of first non-repeating character or -1 if there is no non-repeating character</returns>
        public static int UniqueChar(string s)
        {
            List<char> reject = new List<char>();
            Dictionary<char, int> hold = new Dictionary<char, int>();
            if (s == null)
                return -1;
            int idx = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (reject.Contains(s[i]))
                    continue;
                if (hold.ContainsKey(s[i]))
                {
                    reject.Add(s[i]);
                    hold.Remove(s[i]);
                    continue;
                }
                hold.Add(s[i], i);
            }
            foreach (KeyValuePair<char, int> uniq in hold)
            {
                if (uniq.Value < idx || idx == -1)
                    idx = uniq.Value;
            }
            return (idx);
        }
    }
}
