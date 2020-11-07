using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// task: https://edabit.com/challenge/A3Nt3ae39NTFxbtAF

namespace LookAndSaySequence
{
    public class LookAndSay
    {
        public static IEnumerable<long> Run(long start, int n)
        {
            var textNumbers = start.ToString();
            
            var result = new List<long>();

            for (int i = 0; i < n; i++)
            {
                result.Add(Convert.ToInt64(textNumbers));                  
                textNumbers = CreateLookAndSayGroups(textNumbers);
            }
            return result;
        }

        private static string CreateLookAndSayGroups(string numbersText)
        {
            var sb = new StringBuilder();
            var counter = 0;
            var first = numbersText[0];
            for (int i = 0; i < numbersText.Length; i++)
            {
                var currentChar = numbersText[i];
                if (currentChar == first)
                {
                    counter++;
                    first = currentChar;
                }
                else
                {
                    sb.Append(counter);
                    sb.Append(first);
                    counter = 1;
                    first = currentChar;
                }
            }
            sb.Append(counter);
            sb.Append(first);
            return sb.ToString();
        }
    }
}