using NUnit.Framework;

namespace TrianglePoints
{
    [TestFixture]
    public class TrianglePointsTests
    {
        [TestCase(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 4, 5 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 3, 2 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 7 }, new int[] { 2, 4 }, new int[] { 9, 3 }, new int[] { 2, 6 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 7 }, new int[] { 2, 4 }, new int[] { 9, 3 }, new int[] { 6, 5 }, ExpectedResult = false)]
        [TestCase(new int[] { -2, 6 }, new int[] { 12, -3 }, new int[] { 1, 7 }, new int[] { 9, -1 }, ExpectedResult = true)]
        [TestCase(new int[] { -2, 6 }, new int[] { 12, -3 }, new int[] { 1, 7 }, new int[] { 4, 2 }, ExpectedResult = false)]
        [TestCase(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 4, 2 }, ExpectedResult = true)]
        [TestCase(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 0, -4 }, ExpectedResult = false)]    
        public static bool TestWithinTriangle(int[] p1, int[] p2, int[] p3, int[] test)
        {
            return TrianglePointsSolver.WithinTriangle(p1, p2, p3, test);
        }
    }
}
