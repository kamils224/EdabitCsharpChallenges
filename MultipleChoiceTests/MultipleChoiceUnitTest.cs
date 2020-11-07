using System;
using NUnit.Framework;
using MultipleChoiceTest;

namespace MultipleChoiceTest
{
    [TestFixture]
    public class Tests 
    {
        [Test]
        public static void TestMultipleChoiceTests()
        {
            var paper1 = new Testpaper("Maths", new string[] {"1A", "2C", "3D", "4A", "5A"}, "60%");
            var paper2 = new Testpaper("Chemistry", new string[] {"1C", "2C", "3D", "4A"}, "75%");
            var paper3 = new Testpaper("Computing", new string[] {"1D", "2C", "3C", "4B", "5D", "6C", "7A"}, "75%");
            var paper4 = new Testpaper("Physics", new string[] {"1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A"}, "90%");

            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();

            Assert.IsTrue(paper1 is ITestpaper, "The Testpaper class does not implement the ITestpaper interface");
            Assert.IsTrue(student1 is IStudent, "The Student class does not implement the IStudent interface");
            Assert.IsFalse(student1 is ITestpaper, "The Student class should not implement the ITestpaper interface");
            Assert.IsFalse(paper1 is IStudent, "The Testpaper class should not implement the IStudent interface");

            Assert.AreEqual(student1.TestsTaken, new string[] { "No tests taken" });
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            Assert.AreEqual(student1.TestsTaken, new string[] { "Maths: Passed! (80%)" });

            student2.TakeTest(paper2, new string[] {"1C", "2D", "3A", "4C"});
            student2.TakeTest(paper3, new string[] {"1A", "2C", "3A", "4C", "5D", "6C", "7B"});
            Assert.AreEqual(student2.TestsTaken, new string[] { "Chemistry: Failed! (25%)", "Computing: Failed! (43%)"});

            Assert.AreEqual(student3.TestsTaken, new string[] { "No tests taken" });
            student3.TakeTest(paper1, new string[] {"1C", "2D", "3A", "4C", "5A"});
            student3.TakeTest(paper3, new string[] {"1A", "2C", "3A", "4C", "5D", "6C", "7B"});
            Assert.AreEqual(student3.TestsTaken, new string[] { "Computing: Failed! (43%)", "Maths: Failed! (20%)" });
            student3.TakeTest(paper4, new string[] {"1A", "2C", "3A", "4C", "5D", "6C", "7B", "8C", "9D", "10A", "11A"});
            Assert.AreEqual(student3.TestsTaken, new string[] { "Computing: Failed! (43%)", "Maths: Failed! (20%)", "Physics: Failed! (73%)"});

            Assert.AreEqual(paper1.Subject, "Maths");
            Assert.AreEqual(paper2.Subject, "Chemistry");
            Assert.AreEqual(paper3.Subject, "Computing");
            Assert.AreEqual(paper4.Subject, "Physics");

            Assert.AreEqual(paper1.MarkScheme, new string[] {"1A", "2C", "3D", "4A", "5A"});
            Assert.AreEqual(paper2.MarkScheme, new string[] {"1C", "2C", "3D", "4A"});
            Assert.AreEqual(paper3.MarkScheme, new string[] {"1D", "2C", "3C", "4B", "5D", "6C", "7A"});
            Assert.AreEqual(paper4.MarkScheme, new string[] {"1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A"});

            Assert.AreEqual(paper1.PassMark, "60%");
            Assert.AreEqual(paper2.PassMark, "75%");
            Assert.AreEqual(paper3.PassMark, "75%");
            Assert.AreEqual(paper4.PassMark, "90%");
        }
    }
}