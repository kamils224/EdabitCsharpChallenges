using MultipleChoiceTest;

namespace CsharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var paper1 = new Testpaper("Maths", new string[] {"1A", "2C", "3D", "4A", "5A"}, "60%");
            var paper2 = new Testpaper("Chemistry", new string[] {"1C", "2C", "3D", "4A"}, "75%");
            var paper3 = new Testpaper("Computing", new string[] {"1D", "2C", "3C", "4B", "5D", "6C", "7A"}, "75%");
            var paper4 = new Testpaper("Physics", new string[] {"1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A"}, "90%");

            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();
            
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });

            student2.TakeTest(paper2, new string[] {"1C", "2D", "3A", "4C"});
            student2.TakeTest(paper3, new string[] {"1A", "2C", "3A", "4C", "5D", "6C", "7B"});

            student3.TakeTest(paper1, new string[] {"1C", "2D", "3A", "4C", "5A"});
            student3.TakeTest(paper3, new string[] {"1A", "2C", "3A", "4C", "5D", "6C", "7B"});
            student3.TakeTest(paper4, new string[] {"1A", "2C", "3A", "4C", "5D", "6C", "7B", "8C", "9D", "10A", "11A"});
            
            
            var tests1 = student1.TestsTaken;
            var tests2 = student2.TestsTaken;
            var tests3 = student3.TestsTaken;
            
            
            
            System.Console.WriteLine("end");

        }
    }
}
