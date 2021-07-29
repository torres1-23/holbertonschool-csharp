using System;

namespace Text
{
    /// <summary>Contains operations performed on text.</summary>
    public class Str
    {
        /// <summary>Determines how many words are in a string</summary>
        /// <param name="s">String to check.</param>
        /// <returns>Number of words in the string</returns>
        public static int CamelCase(string s)
        {
            int count = 1;
            if (s == null || s.Length == 0)
                return (0);
            foreach (char daffy in s)
            {
                if (Char.IsUpper(daffy))
                    count++;
            }
            return (count);
        }
    }
}
