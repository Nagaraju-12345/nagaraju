using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicCalculator
{
    interface Calculator
    {
        Double addNumber(Double num1, Double num2);
        Double substract(Double num1, Double num2);

        Double multiply(Double num1, Double num2);

        Double divideNumber(Double num1, Double num2);
        Double sqrtnumber(Double x);
    }
}
