using FareySequence;
using MaxieAndMinnie;
using MultipleChoiceTest;
using PowerfulPrime;

namespace CsharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {        
            var result = MaxieMinnie.GetMaxMin(116962727585478L); 
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
