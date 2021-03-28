using Primeiro.ApiWeb.HyperMediaLink.Abstract;
using System.Collections.Generic;

namespace Primeiro.ApiWeb.HyperMediaLink.Filtros
{
    public class HypermediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
