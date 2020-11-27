using System;
using System.Collections.Generic;
using System.Linq;

// task: https://edabit.com/challenge/nMW5Tb8odgy3ePvGy

namespace MaxieAndMinnie
{
    public class MaxieMinnie
    {
        public static long[] GetMaxMin(long n)
        {
            var numbersChars = new List<char>(Convert.ToString(n).ToCharArray());
            var maxResult = GetMaxie(numbersChars);
            var minResult = GetMinnie(numbersChars);       
            return new long[] 
            {
                maxResult, 
                minResult
            };
        }

        private static long GetMaxie(List<char> numbersChars)
        {
            var maxResult = new List<char>(numbersChars);
            var maxChar = Enumerable.Max(numbersChars);
            var maxCharIndex = numbersChars.LastIndexOf(maxChar);
            if (maxCharIndex != 0)
            {
                var swapIndex = 0;
                while(swapIndex < maxResult.Count && maxResult[swapIndex] == maxChar) 
                {
                    swapIndex++;
                }
                if (swapIndex < maxResult.Count)
                {
                    var temp = maxResult[maxCharIndex];  
                    maxResult[maxCharIndex] = maxResult[swapIndex];
                    maxResult[swapIndex] = temp; 
                }
            }
            return Convert.ToInt64(new string(maxResult.ToArray()));
        }

        private static long GetMinnie(List<char> numbersChars)
        {
            var minResult = new List<char>(numbersChars);
            var first = minResult[0];

            var min = Enumerable.Min(minResult);
            var minIndex = minResult.LastIndexOf(min);
            var nonZeroMin = Enumerable.Min(minResult.Where(x => x != '0'));
            var nonZeroMinIndex = minResult.LastIndexOf(nonZeroMin);


            if (minResult[nonZeroMinIndex] < first && nonZeroMinIndex > 0)
            {
                Swap(minResult, 0, nonZeroMinIndex);
                return Convert.ToInt64(new string(minResult.ToArray()));
            }

            for (int i = 1; i < minResult.Count; i++)
            {
                if (minResult[minIndex] >= minResult[i]) {continue;}
                if (minIndex > i)
                {
                    Swap(minResult, i, minIndex);
                    return Convert.ToInt64(new string(minResult.ToArray()));
                }
                else
                {
                    min = Enumerable.Min(minResult.Skip(i));
                    minIndex = minResult.LastIndexOf(min);
                    i--; 
                }
            }
            return Convert.ToInt64(new string(minResult.ToArray()));
        }
        private static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}