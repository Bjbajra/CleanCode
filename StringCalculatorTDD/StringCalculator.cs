using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string numberString = numbers;
            List<char>? delimiters = new List<char> { ',', '\n' };

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');
                var newDelimiter = splitInput.First().Trim('/');
                numberString = String.Join('\n', splitInput.Skip(1));
                delimiters.Add(Convert.ToChar(newDelimiter));
            }
            int result = numberString.Split(delimiters.ToArray())
                .Select(s => int.Parse(s))
                .Sum();

            return result;
        }
    }
}
