using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Models
{
    interface ICalculator
    {
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public string Operation { get; set; }

    }
}
