using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Services
{
    public class CalculatorService
    {

        public decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue)) return decimalValue;
            return 0;
        }

        public bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);

            return isNumber;
        }
    

    public decimal Calc(string operation, decimal n1, decimal n2)
        {
            if (operation == "sum") return n1 + n2;
            else if (operation == "sub") return n1 - n2;
            else if (operation == "div") return n1 / n2;
            else if (operation == "mul") return n1 * n2;
            else if (operation == "med") return (n1 + n2) / 2;
            else return 'e';
        }
    }
}
