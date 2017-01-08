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
                var splittedNumbers = SplitString(numbers);

                foreach (var number in splittedNumbers)
                {
                    result = result + Int32.Parse(number);
                }
            }

            return result;
        }

        private string[] SplitString(string str)
        {
            string[] splittedString = new string [0];

            if (str.Contains("//"))
            {
                str = str.Replace("//", "");
                int beforeNewLineSign = str.IndexOf('\n');

                string delimiter = str.Substring(0, beforeNewLineSign);
                splittedString = str.Split(new []{ "\n",  delimiter }, 
                    StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                splittedString = str.Split('\n', ',');
            }
            return splittedString;
        }
    }
}