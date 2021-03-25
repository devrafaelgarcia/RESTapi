using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Primeiro.ApiWeb.Models;
using Primeiro.ApiWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;
        private readonly CalculatorService _calculatorService;

        public CalculatorController(ILogger<CalculatorController> logger, CalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        [HttpGet("{op}/{firstNumber}/{secondNumber}")] //Get vai ter um Path especifico
        public IActionResult Get(string firstNumber, string secondNumber, string op)
        {

            Calculator calc = new Calculator(firstNumber, secondNumber, op);
            if(_calculatorService.IsNumeric(firstNumber) && _calculatorService.IsNumeric(secondNumber))
            {
                var sum =
                _calculatorService.Calc(op,
                _calculatorService.ConvertToDecimal(firstNumber),
                _calculatorService.ConvertToDecimal(secondNumber));

                return Ok(sum.ToString());
            }


            return BadRequest();


            //Porque colocamos como string, poderiamos passar com decimal, para ter noções de validações
           // if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
          //  {
           //     var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
           //     return Ok(sum.ToString()); //Retorna ok e um tostring
           // }
            //return BadRequest("Invalid Input"); //Vai vim quando vier um input invalido
        }

      /*  private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue)) return decimalValue;
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);

            return isNumber;*/
        
    }
}
