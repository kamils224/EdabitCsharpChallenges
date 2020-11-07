using System.Data;
using NUnit.Framework;

namespace MiserableCalculator
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase("23+4", ExpectedResult=27)]
        [TestCase("45-15", ExpectedResult=30)]
        [TestCase("13+2-5*2", ExpectedResult=5)]
        [TestCase("49/7*2-3", ExpectedResult=11)]
        [TestCase("2+2*2", ExpectedResult=6)]
        [TestCase("5/2", ExpectedResult=2.5)]
        [TestCase("-34/4", ExpectedResult=-8.5)]
        [TestCase("0+43-0+56*0", ExpectedResult=43)]
        [TestCase("-14*2-37-0", ExpectedResult=-65)]
        [TestCase("0*0", ExpectedResult=0)]
        [TestCase("4+2+3-5*2-8/4-12-0+3-14", ExpectedResult=-26)]
        [TestCase("9/2+9/4", ExpectedResult=6.75)]
        [TestCase("56*27*18*12/2*0", ExpectedResult=0)]
        [TestCase("34/4*0*45*7", ExpectedResult=0)]
        public static double FixedTest(string n)
        {
            Calculator calculator  = new Calculator();
            return calculator.Calculate(n);
            //DataTable dt = new DataTable();
		    //return double.Parse(dt.Compute(n,"").ToString());
        }
    }
}

