using System;
using System.Collections.Generic;


// task: https://edabit.com/challenge/u2j86CBJibQA5KzQp

namespace MiserableCalculator
{
    public class Calculator
    {
        private List<char> OPERATION_SIGNS = new List<char>()
        {
            '+',
            '-',
            '/',
            '*',
        };
        private class ParsedText
        {
            public List<double> numbers;
            public List<char> signs;

        }

        public double Calculate(string text)
        {
            var parsedText = ParseOperationText(text);
            var numbers = parsedText.numbers;
            var signs = parsedText.signs;
            if (numbers.Count - 1 != signs.Count)
            {
                throw new ArgumentException("Invalid math operation text!");
            }
            return PerformOperations(numbers, signs);
        }

        private ParsedText ParseOperationText(string text)
        {
            var numbersAsText = new List<string>(text.Split(OPERATION_SIGNS.ToArray()));
            var numbers = new List<double>();
            var signs = new List<char>();

            var minus = '-';        
            if (text[0] == minus)
            {
                numbersAsText[0]="0";
            }
            numbersAsText.ForEach(x=> numbers.Add(double.Parse(x)));

            foreach (var character in text)
            {
                if (OPERATION_SIGNS.Contains(character)) signs.Add(character);
            }

            return new ParsedText(){ numbers = numbers, signs = signs };
        }
        private double PerformOperations(List<double> numbers, List<char> signs)
        {
            var multiplication = '*';
            var division = '/'; 
            var resultNumbers = new List<double>();
            var resultSigns = new List<char>();

            var acc = numbers[0];
            var numResults = new List<double>();
            var signResults = new List<char>();
            for (int i = 0; i < numbers.Count - 1; i++)
            {   
                var currentChar = signs[i];
                if (currentChar == division || currentChar == multiplication)
                {   
                    var left = acc;
                    acc = numbers[i+1];
                    acc = CharToOperation(left, acc, currentChar);           
                }
                else
                {
                    numResults.Add(acc);
                    signResults.Add(currentChar);
                    acc = numbers[i+1];
                }
            }
            numResults.Add(acc);
            var finalResult = numResults[0];
            for (int i = 0; i < numResults.Count - 1; i++)
            {   var left = finalResult;
                finalResult = numResults[i+1];
                finalResult = CharToOperation(left, finalResult, signResults[i]);
            }
            return finalResult;
        }
        private double CharToOperation(double left, double right, char sign)
        {
            switch (sign)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    return left / right;
                default: return 0.0; 
            }
        }
    }
}
