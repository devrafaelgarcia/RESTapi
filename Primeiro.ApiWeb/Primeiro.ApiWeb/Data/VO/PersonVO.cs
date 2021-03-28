using Primeiro.ApiWeb.HyperMediaLink;
using Primeiro.ApiWeb.HyperMediaLink.Abstract;
using System.Collections.Generic;

namespace Primeiro.ApiWeb.Data.Contract.VO
{

    public class PersonVO : ISupportHypermedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Andress { get; set; }


        public string Gender { get; set; }
        public List<HypermediaLink> Links { get; set; } = new List<HypermediaLink>();
    }
}
