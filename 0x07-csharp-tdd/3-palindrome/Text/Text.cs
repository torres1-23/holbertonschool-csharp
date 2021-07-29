using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    /// <summary>Contains operations performed on text.</summary>
    public class Str
    {
        /// <summary>Checks if a string is a palindrome</summary>
        /// <param name="s">String to check</param>
        /// <returns>True if string is palindrome, false otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            List<char> strip = new List<char>();
            foreach (char red in s)
            {
                if (!Char.IsPunctuation(red) && !Char.IsWhiteSpace(red))
                {
                    strip.Add(Char.ToLower(red));
                }
            }
            if (strip.Count == 0)
                return (true);
            List<char> rev = new List<char>(strip);
            rev.Reverse();
            return (strip.SequenceEqual(rev));
        }
    }
}
