
// task: https://edabit.com/challenge/PvCD5nSYy3Dnvnfcq

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeDescendant
{
    public class PalindromeDesc
    {
        public static bool IsPalindromeDescendant(int num) 
        {
            var text = num.ToString();
            if (text.Length % 2 != 0)
            {
                throw new ArgumentException("Input should be even!");
            }
            return ComputePalindromeDesc(text);
        }

        private static bool ComputePalindromeDesc(string text)
        {
            if (text == new string(text.Reverse().ToArray()) || text.Length == 1)
            {
                return true;
            }
            if (text.Length == 2)
            {
                return false;
            }
            var pairs = TakeEvery(text, 2);
            StringBuilder sb  = new StringBuilder();
            foreach (var item in pairs)
            {   
                var sum = 0;
                foreach (var c in item)
                {
                    sum+= (int)char.GetNumericValue(c);
                }
                sb.Append($"{sum}");
            }
            text = sb.ToString();
            return ComputePalindromeDesc(text);
        }
        private static IEnumerable<string> TakeEvery( string s, int count) 
        {
            int index = 0;
            while(index < s.Length) 
            {
                if(s.Length - index >= count) 
                {
                    yield return s.Substring(index, count);
                }
                else 
                {
                    yield return s.Substring(index, s.Length - index);
                }
                index += count;
            }
        }
    }
}