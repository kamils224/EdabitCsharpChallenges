using System.Collections.Generic;
using System.Linq;

// task: https://edabit.com/challenge/wrxoYop5uZKG4nNSb

namespace ThreeSumProblem
{
    public static class Combination
    {
        public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
                elements.SelectMany((e, i) =>
                elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] {e}).Concat(c)));
        }
    }

    // consider Template type instead of int
    class Comparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int[] y)
        {
            if (x.Length != y.Length)
                return false;

            for (int i = 0; i < x.Length; ++i)
                if (!x[i].Equals(y[i]))
                    return false;

                return true;
        }

        public int GetHashCode(int[] obj)
        {
            return string.Join("", obj).GetHashCode();
        }
    }
    public class ThreeSumClass
    {
        private static List<int[]> CreateNSumElements(int[] arr, int n)
        {
            var result = new List<int[]>(); 
            if (arr.Length < n ) { return result; }

            var combinations = arr.DifferentCombinations(n).ToList();
            
            foreach (var item in combinations)
            {
                var sum = 0;

                foreach (var number in item)
                {
                    sum+=number;
                }
                if (sum == 0)
                {
                    result.Add(item.ToArray());
                }
            }
            var distinctResult = result.Distinct(new Comparer());
            return OrderOutput(distinctResult.ToList(), new List<int>(arr));
        }

        private static List<int[]> OrderOutput(List<int[]> resultList, List<int> origin)
        {
            var orderedResult = new List<int[]>(resultList.Count);
            foreach (var item in resultList)
            {
                var itemAsList = new List<int>(item);
                var ordered = new List<int>(itemAsList.Count);
                foreach (var o in origin)
                {
                    if (itemAsList.Contains(o))
                    {
                        ordered.Add(o);
                    }
                }
                if(itemAsList.Count == item.Length)
                {
                    orderedResult.Add(itemAsList.ToArray());
                }
            }
            return orderedResult;
        }

        public static List<int[]> ThreeSumCompute(int[] arr, int n) 
	    {
		    return CreateNSumElements(arr, n);
	    }
    }
}