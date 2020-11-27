using System.Collections.Generic;

namespace FareySequence
{
    public class Farey
    {
        public static string[] Compute(int n)
        {
            var values = new SortedDictionary<float, int[]>();
            values.Add(0f, new int[]{0,1});
            values.Add(1f, new int[]{1,1});

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    var toAdd = (j/(float)i);
                    if (!values.ContainsKey(toAdd))
                    {
                        values.Add(toAdd, new int[]{j, i});
                    }
                }
            }

            var result = new List<string>();
            foreach (var item in values)
            {
                result.Add($"{item.Value[0]}/{item.Value[1]}");
            }
            return result.ToArray();
        }
    }
}