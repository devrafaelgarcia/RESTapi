using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.HyperMediaLink.Abstract
{
    public interface ISupportHypermedia
    {
        List<HypermediaLink> Links { get; set; }
    }
}
