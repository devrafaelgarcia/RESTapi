using Primeiro.ApiWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Models
{
    public class Calculator : ICalculator
    {
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public string Operation { get; set; }

        public Calculator(string number1, string number2, string operation)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;

        }
    }
}
