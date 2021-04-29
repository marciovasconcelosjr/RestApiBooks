using RestAPI_Books.Hypermedia;
using RestAPI_Books.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace WebApplication1.Data.VO
{

    public class BooksVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Titulo { get; set; }

      
        public string Autor { get; set; }

       
        public decimal Preço { get; set; }

      
        public DateTime Launch_date { get; set; }

        public List<HyperMediaLink> Links { get; set;} = new List<HyperMediaLink>();
    }
}
