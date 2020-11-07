using System;
using System.Collections.Generic;
using System.Linq;

// task: https://edabit.com/challenge/MBendPYTARxzRCai4

namespace PackingHelper
{
    public class Packing
    {
        private int bagCapacity = 10;
        public Packing(int bagCapacity)
        {
            this.bagCapacity = bagCapacity;
        }
        public bool CanFit(int[] weights, int bags)
        {
            var sum = weights.Sum();
            if (sum > bags * bagCapacity){ return false; }

            var remainingBags = new int[bags];
            var packed = new List<int>(weights.Length);
            var notPacked = new List<int>(weights); 
            notPacked.Sort((a,b) => b.CompareTo(a));

            for (int i = 0; i < remainingBags.Length; i++)
            {
                for (int j = 0; j < notPacked.Count; j++)
                {
                    var item = notPacked[j];
                    if (bagCapacity - remainingBags[i] >= item)
                    {
                        remainingBags[i] += item;
                        packed.Add(item);
                        notPacked.RemoveAt(j);
                        j--;
                    }
                }               
            }
            return notPacked.Count == 0;
        }
    }
}