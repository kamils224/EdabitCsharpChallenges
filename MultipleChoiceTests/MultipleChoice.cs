using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// task: https://edabit.com/challenge/thXMEAWNWyk9cCZcM

namespace MultipleChoiceTest
{
	public interface ITestpaper
	{
			string Subject { get; }
			string[] MarkScheme { get; }
			string PassMark { get; }
	}

	public interface IStudent
	{
			string[] TestsTaken { get; }
			void TakeTest(ITestpaper paper, string[] answers);
	}

    public class Testpaper : ITestpaper
    {
		public Testpaper(string subject, string[] markScheme, string passMark)
		{
			this.Subject = subject;
			this.MarkScheme = markScheme;
			this.PassMark = passMark;
		}
        public string Subject  { get; }

        public string[] MarkScheme { get; }

        public string PassMark { get; }
    }

    public class Student : IStudent
    {
		private Regex rx = new Regex(@"\d+");
		private string successInfo = "Passed!";
		private string failInfo = "Failed!";
		private List<string> tests;
        public string[] TestsTaken
		{
			get 
			{
				if (tests.Count == 0)
				{
					return new string[] { "No tests taken" };
				} 
				else
				{
					return tests.ToArray();
				}
			}
		}

		public Student()
		{
			tests = new List<string>();
		}
        public void TakeTest(ITestpaper paper, string[] answers)
        {
			var questions = new HashSet<string>(paper.MarkScheme);
			var all = questions.Count;
			var correct = 0;
			var passText = rx.Match(paper.PassMark).Value;
			var passPercentage = double.Parse(passText)/100.0;

			foreach(var answer in answers)
			{
				if (questions.Contains(answer))
				{
					correct++;
				}
			}
			var score = correct/(double)all;
			var scorePercentText = "(" + Math.Round(score * 100.0, MidpointRounding.AwayFromZero).ToString()+"%)";
			
			var resultScore = score >= passPercentage ? $"{successInfo} {scorePercentText}" : $"{failInfo} {scorePercentText}";
			var result = $"{paper.Subject}: {resultScore}";
			tests.Add(result);
			tests.Sort();
        }
    }
}