using NUnit.Framework;


namespace DoubleLettersCheck
{
    

    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("loop", ExpectedResult=true)]
        [TestCase("meeting", ExpectedResult=true)]
        [TestCase("yummy", ExpectedResult=true)]
        [TestCase("toodles", ExpectedResult=true)]
        [TestCase("droop", ExpectedResult=true)]
        [TestCase("loot", ExpectedResult=true)]
        [TestCase("orange", ExpectedResult=false)]
        [TestCase("munchkin", ExpectedResult=false)]
        [TestCase("forestry", ExpectedResult=false)]
        [TestCase("raindrops", ExpectedResult=false)]
        [TestCase("gold", ExpectedResult=false)]
        [TestCase("paradise", ExpectedResult=false)]
        [TestCase("chicken", ExpectedResult=false)]
        public static bool FixedTest(string word)
        {
            return DoubleLetters.HasConsequtiveLetters(word, 2);
        }
    }
}