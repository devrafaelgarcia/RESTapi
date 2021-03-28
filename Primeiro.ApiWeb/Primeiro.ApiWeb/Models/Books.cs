using Primeiro.ApiWeb.Models.Base;
using Primeiro.ApiWeb.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeiro.ApiWeb.Models
{

    [Table("books")]
    public class Books : BaseEntity
    {

        [Column("author")]
        public string Autor { get; set; }

        [Column("launch_date")]
        public DateTime Date { get; set; }

        [Column("price")]
        public double Prince { get; set; }

        [Column("title")]
        public string Title { get; set; }

    }
}
