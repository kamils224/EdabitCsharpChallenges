using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.Collections;

// task: https://edabit.com/challenge/cR976ve6HR7bzBaEa

namespace PowerfulPrime
{
    public class PowerfulPrimeFactors
    {
        public static string ExpressFactors(int n)
        {
            return FactorsToString(FindPrimeFactors(n));
        }
        private static string FactorsToString(List<int> factors)
        {
            var sorted = factors.OrderBy(x=>x).ToList();
            var factorsDict = new OrderedDictionary();
            

            foreach (var item in sorted)
            {
                if (!factorsDict.Contains(item))
                {
                    factorsDict.Add(item, new List<string>(){item.ToString()});
                }
                else
                {
                    var factorsText = factorsDict[(object)item] as List<string>;
                    factorsText.Add(item.ToString());
                }
            }

            var factorsTextParts = new List<string>();
            foreach (DictionaryEntry item in factorsDict)
            {
                var textList = item.Value as List<string>;
                var toAdd = (int)item.Key;
                if (textList.Count == 1)
                {
                    factorsTextParts.Add(toAdd.ToString());
                }
                else
                {
                    factorsTextParts.Add($"{toAdd}^{textList.Count}");
                }
            }     
            return string.Join(" x ", factorsTextParts);
        }
        private static List<int> FindPrimeFactors(int n)
        {
            if (n == 2)
            {
                return new List<int>() {2};
            }
            var primes = GetPrimes(n/2);
            var currentPrimeIndex = 0;
            var factors = new List<int>();

            var currentPrime = primes[currentPrimeIndex];
            var currentValue = n; 

            while (currentPrimeIndex < primes.Count)
            {
                currentPrime = primes[currentPrimeIndex];
                if (currentValue % currentPrime == 0)
                {
                    factors.Add(currentPrime);
                    currentValue /= currentPrime; 
                } 
                else
                {
                    currentPrimeIndex++;  
                } 
            }
            if (factors.Count == 0){factors.Add(n);}
            return factors;
        }
        private static List<int> GetPrimes(int n)
        {
            bool[] primes = new bool[n+1];
            for (int i = 2; i * i <= n; i++)
            {
                if (primes[i])
                {
                    continue;
                }
                for (int j = 2 * i; j <= n; j += i)
                {
                    primes[j] = true;    
                }
                
            }
            var result = new List<int>();
            for (int i = 2; i < primes.Length; i++)
            {
                if (!primes[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}