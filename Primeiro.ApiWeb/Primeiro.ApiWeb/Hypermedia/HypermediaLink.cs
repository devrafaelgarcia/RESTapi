using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.HyperMediaLink
{
    public class HypermediaLink
    {
        public string Rel { get; set; }
        private string href;
        public string Href
        {
            get
            {
                object _lock = new object();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("2%F", "/").ToString();
                }
            }
        
        set { href = value; }

} // Quando temos / na url, o dot net converte / %
public string Type { get; set; }
public string Action { get; set; }
    }
}
