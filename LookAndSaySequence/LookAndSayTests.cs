using NUnit.Framework;
using System.Linq;

namespace LookAndSaySequence
{
    [TestFixture]
    public class LookAndSayTests
    {
            [TestCase(1, 7, ExpectedResult=new long[] { 1, 11, 21, 1211, 111221, 312211, 13112221 })]
            [TestCase(123, 4, ExpectedResult=new long[] { 123, 111213, 31121113, 1321123113 })]
            [TestCase(70, 5, ExpectedResult=new long[] { 70, 1710, 11171110, 31173110, 132117132110 })]
            [TestCase(111312211, 2, ExpectedResult=new long[] { 111312211, 3113112221 })]
            [TestCase(2, 8, ExpectedResult=new long[] { 2, 12, 1112, 3112, 132112, 1113122112, 311311222112, 13211321322112 })]
            [TestCase(144, 4, ExpectedResult=new long[] { 144, 1124, 211214, 1221121114 })]
            [TestCase(11111111, 3, ExpectedResult=new long[] { 11111111, 81, 1811 })]
            [TestCase(0, 4, ExpectedResult=new long[] { 0, 10, 1110, 3110 })]
        public static long[] TestLookAndSay(long start, int n)
        {
            return LookAndSay.Run(start, n).ToArray();
        }
    }
}