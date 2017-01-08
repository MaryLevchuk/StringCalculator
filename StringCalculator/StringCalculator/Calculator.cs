using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            int result = 0;
           
            if (numbers.Length != 0)
            {
                var splittedNumbers = numbers.Split('\n', ',');

                foreach (var number in splittedNumbers)
                {
                    result = result + Int32.Parse(number);
                }
            }

            return result;
        }
    }
}