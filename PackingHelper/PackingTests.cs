using NUnit.Framework;

namespace PackingHelper
{
    [TestFixture]
public class PackingTests
{
    [TestCase(new int[] { 2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 }, 4, ExpectedResult=true)]
	[TestCase(new int[] { 7, 1, 2, 6, 1, 2, 3, 5, 9, 2, 1, 2, 5 }, 5, ExpectedResult=true)]
	[TestCase(new int[] { 2, 7, 1, 3, 3, 4, 7, 4, 1, 8, 2 }, 4, ExpectedResult=false)]
	[TestCase(new int[] { 1, 3, 3, 3, 2, 1, 1, 9, 7, 10, 8, 6, 1, 2, 9 }, 8, ExpectedResult=true)]
	[TestCase(new int[] { 4, 1, 2, 3, 5, 5, 1, 9 }, 3, ExpectedResult=true)]
	[TestCase(new int[] { 3, 1, 2, 7, 2, 6, 1 }, 3, ExpectedResult=true)]
	[TestCase(new int[] { 4, 6, 1, 9, 6, 1, 1, 9, 2, 9 }, 5, ExpectedResult=true)]
	[TestCase(new int[] { 2, 2, 10, 10, 1, 5, 2 }, 4, ExpectedResult=true)]
	[TestCase(new int[] { 9, 6, 2, 3, 1, 2, 4, 8, 3, 1, 3 }, 4, ExpectedResult=false)]
	[TestCase(new int[] { 2, 5, 1, 6, 2, 9, 5, 2, 1, 6, 1, 6, 6, 1 }, 5, ExpectedResult=false)]
	[TestCase(new int[] { 2, 5, 1, 6, 2, 9, 5, 2, 1, 6, 1, 6, 6, 1 }, 6, ExpectedResult=true)]
	[TestCase(new int[] { 1, 2, 3, 2, 6, 4, 1 }, 2, ExpectedResult=true)]
	[TestCase(new int[] { 1, 1, 2, 1, 2, 10, 2, 2, 5, 1, 5 }, 4, ExpectedResult=true)]
	[TestCase(new int[] { 8, 3, 2, 1, 1, 2, 1, 3, 2, 1 }, 3, ExpectedResult=true)]
	[TestCase(new int[] { 10 }, 1, ExpectedResult=true)]
    public static bool TestCanFit(int[] wts, int n)
    {
        var packing = new Packing(10);
        return packing.CanFit(wts, n);
    }
}
}
