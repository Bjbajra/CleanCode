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

            char[]? seperators = new[] { ',', '\n' };
            int result = numbers.Split(seperators)
                .Select(s => int.Parse(s))
                .Sum();

            return (result);
        }
    }
}
