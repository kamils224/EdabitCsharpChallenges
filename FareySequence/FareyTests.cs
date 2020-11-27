using NUnit.Framework;
using System;

namespace FareySequence
{
    [TestFixture]
    public class FareyTests
    {
        [Test]
        [TestCase(2, ExpectedResult = new string[] { "0/1", "1/2", "1/1" })]
        [TestCase(3, ExpectedResult = new string[] { "0/1", "1/3", "1/2", "2/3", "1/1" })]
        [TestCase(4, ExpectedResult = new string[] { "0/1", "1/4", "1/3", "1/2", "2/3", "3/4", "1/1" })]
        [TestCase(5, ExpectedResult = new string[] { "0/1", "1/5", "1/4", "1/3", "2/5", "1/2", "3/5", "2/3", "3/4", "4/5", "1/1" })]
        [TestCase(6, ExpectedResult = new string[] { "0/1", "1/6", "1/5", "1/4", "1/3", "2/5", "1/2", "3/5", "2/3", "3/4", "4/5", "5/6", "1/1" })]
        [TestCase(7, ExpectedResult = new string[] { "0/1", "1/7", "1/6", "1/5", "1/4", "2/7", "1/3", "2/5", "3/7", "1/2", "4/7", "3/5", "2/3", "5/7", "3/4", "4/5", "5/6", "6/7", "1/1" })]
        [TestCase(8, ExpectedResult = new string[] { "0/1", "1/8", "1/7", "1/6", "1/5", "1/4", "2/7", "1/3", "3/8", "2/5", "3/7", "1/2", "4/7", "3/5", "5/8", "2/3", "5/7", "3/4", "4/5", "5/6", "6/7", "7/8", "1/1" })]
        [TestCase(9, ExpectedResult = new string[] { "0/1", "1/9", "1/8", "1/7", "1/6", "1/5", "2/9", "1/4", "2/7", "1/3", "3/8", "2/5", "3/7", "4/9", "1/2", "5/9", "4/7", "3/5", "5/8", "2/3", "5/7", "3/4", "7/9", "4/5", "5/6", "6/7", "7/8", "8/9", "1/1" })]
        [TestCase(10, ExpectedResult = new string[] { "0/1", "1/10", "1/9", "1/8", "1/7", "1/6", "1/5", "2/9", "1/4", "2/7", "3/10", "1/3", "3/8", "2/5", "3/7", "4/9", "1/2", "5/9", "4/7", "3/5", "5/8", "2/3", "7/10", "5/7", "3/4", "7/9", "4/5", "5/6", "6/7", "7/8", "8/9", "9/10", "1/1" })]
        [TestCase(11, ExpectedResult = new string[] { "0/1", "1/11", "1/10", "1/9", "1/8", "1/7", "1/6", "2/11", "1/5", "2/9", "1/4", "3/11", "2/7", "3/10", "1/3", "4/11", "3/8", "2/5", "3/7", "4/9", "5/11", "1/2", "6/11", "5/9", "4/7", "3/5", "5/8", "7/11", "2/3", "7/10", "5/7", "8/11", "3/4", "7/9", "4/5", "9/11", "5/6", "6/7", "7/8", "8/9", "9/10", "10/11", "1/1" })]
        [TestCase(12, ExpectedResult = new string[] { "0/1", "1/12", "1/11", "1/10", "1/9", "1/8", "1/7", "1/6", "2/11", "1/5", "2/9", "1/4", "3/11", "2/7", "3/10", "1/3", "4/11", "3/8", "2/5", "5/12", "3/7", "4/9", "5/11", "1/2", "6/11", "5/9", "4/7", "7/12", "3/5", "5/8", "7/11", "2/3", "7/10", "5/7", "8/11", "3/4", "7/9", "4/5", "9/11", "5/6", "6/7", "7/8", "8/9", "9/10", "10/11", "11/12", "1/1" })]
        [TestCase(13, ExpectedResult = new string[] { "0/1", "1/13", "1/12", "1/11", "1/10", "1/9", "1/8", "1/7", "2/13", "1/6", "2/11", "1/5", "2/9", "3/13", "1/4", "3/11", "2/7", "3/10", "4/13", "1/3", "4/11", "3/8", "5/13", "2/5", "5/12", "3/7", "4/9", "5/11", "6/13", "1/2", "7/13", "6/11", "5/9", "4/7", "7/12", "3/5", "8/13", "5/8", "7/11", "2/3", "9/13", "7/10", "5/7", "8/11", "3/4", "10/13", "7/9", "4/5", "9/11", "5/6", "11/13", "6/7", "7/8", "8/9", "9/10", "10/11", "11/12", "12/13", "1/1" })]
        public static string[] TestFarey(int n) 
        {
            return Farey.Compute(n);
        }
    }
}