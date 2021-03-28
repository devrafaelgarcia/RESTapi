using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Models.Interfaces
{
    interface IBooks
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public DateTime Date { get; set; }
        public double Prince { get; set; }
        public string Title { get; set; }
    }
}
