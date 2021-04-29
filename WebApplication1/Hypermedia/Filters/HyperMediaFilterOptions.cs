using RestAPI_Books.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestAPI_Books.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {   
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
