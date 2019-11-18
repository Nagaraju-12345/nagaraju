using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicCalculator
{
    public class floatCalculations : Calculator
    {
    
        public Double addNumber(Double num1, Double num2)
        {
            return num1 + num2;
        }

    
        public Double divideNumber(Double num1, Double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            else
                return num1 / num2;
        }

    
        public Double multiply(Double num1, Double num2)
        {
            return num1* num2;
        }

    
        public Double substract(Double num1, Double num2)
        {
            return num1 - num2;
        }

        public double sqrtnumber(double num1)
        {
            Double sqrt = Math.Sqrt(num1);
            return sqrt;
        }
    }
}
