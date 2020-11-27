using NUnit.Framework;
using System;

namespace PowerfulPrime
{
    [TestFixture]
    public class TPowerfulPrimeFactorsTests
    {
        [TestCase(2, ExpectedResult="2")]
        [TestCase(4, ExpectedResult="2^2")]
        [TestCase(10, ExpectedResult="2 x 5")]
        [TestCase(11, ExpectedResult="11")]
        [TestCase(29, ExpectedResult="29")]
        [TestCase(60, ExpectedResult="2^2 x 3 x 5")]
        [TestCase(100, ExpectedResult="2^2 x 5^2")]
        [TestCase(151, ExpectedResult="151")]
        [TestCase(323, ExpectedResult="17 x 19")]
        [TestCase(997, ExpectedResult="997")]
        [TestCase(3349, ExpectedResult="17 x 197")]
        [TestCase(5040, ExpectedResult="2^4 x 3^2 x 5 x 7")]
        [TestCase(6097, ExpectedResult="7 x 13 x 67")]
        [TestCase(8192, ExpectedResult="2^13")]
        [TestCase(9870, ExpectedResult="2 x 3 x 5 x 7 x 47")]
        [TestCase(9973, ExpectedResult="9973")]
        [TestCase(9999, ExpectedResult="3^2 x 11 x 101")]
        public static string TestExpressFactors(int n)
        {
            Console.WriteLine($"Input: n={n}");
            return PowerfulPrimeFactors.ExpressFactors(n);
        }
    }
}