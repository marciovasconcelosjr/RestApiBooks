using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model.Base;

namespace WebApplication1.Model
{
    [Table("books")]
    public class Books : BaseEntity
    {
        [Column("title")]
        public string Titulo { get; set; }

        [Column("author")]
        public string Autor { get; set; }

        [Column("price")]
        public decimal Preço { get; set; }

        [Column("launch_date")]
        public DateTime Launch_date { get; set; }

    }
}
