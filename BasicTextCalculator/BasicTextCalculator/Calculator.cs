using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BasicTextCalculator
{
    public class Calculator
    {
        public bool Running = true;

        public void Run()
        {
            while (Running)
            {
                AskUserForFormula();
            }
        }

        public void AskUserForFormula()
        {
            Console.WriteLine("Please write a simple math equation:");
            var input = Console.ReadLine();
            ParseAndCalculateInput(input);
        }

        public void ParseAndCalculateInput(string s)
        {
            s = s.Replace(" ", string.Empty);

            if (s == "exit")
            {
                Running = false;
                return;
            }

            decimal result;

            var addSplit = s.Split('+');
            var subSplit = s.Split('-');
            var mltSplit = s.Split('*');
            var divSplit = s.Split('/');

            if (addSplit.Length > 1)
            {
                result = AddNumbers(Convert.ToDecimal(addSplit[0]), Convert.ToDecimal(addSplit[1]));
            }
            else if (subSplit.Length > 1)
            {
                result = SubtractNumbers(Convert.ToDecimal(subSplit[0]), Convert.ToDecimal(subSplit[1]));
            }
            else if (mltSplit.Length > 1)
            {
                result = MultiplyNumbers(Convert.ToDecimal(mltSplit[0]), Convert.ToDecimal(mltSplit[1]));
            }
            else if (divSplit.Length > 1)
            {
                result = DivideNumbers(Convert.ToDecimal(divSplit[0]), Convert.ToDecimal(divSplit[1]));
            }
            else
            {
                Console.WriteLine("Unknown operation. Try something else.");
                return;
            }

            Console.WriteLine("Result is " + result);
        }

        public decimal AddNumbers(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal SubtractNumbers(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal MultiplyNumbers(decimal a, decimal b)
        {
            return a * b;
        }

        /// <summary>
        /// Returns the result of dividing a by b
        /// </summary>
        /// <param name="a">Numerator</param>
        /// <param name="b">Divisor</param>
        /// <returns></returns>
        public decimal DivideNumbers(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
