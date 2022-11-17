using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Calculator
    {
        public int Addition(int number1, int number2)
        {
            return number1 + number2;

        }

        public int Addition(string number1, string number2)
        {
            return Convert.ToInt32(number1) + Convert.ToInt32(number2);

        }


        public int Subtraction(int number1, int number2)
        {
            return number1 - number2;

        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;

        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;

        }
    }
}
