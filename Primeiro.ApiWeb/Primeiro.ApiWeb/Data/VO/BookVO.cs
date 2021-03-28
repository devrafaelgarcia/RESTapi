using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Autor { get; set; }
        public DateTime Date { get; set; }
        public double Prince { get; set; }
        public string Title { get; set; }
    }
}
