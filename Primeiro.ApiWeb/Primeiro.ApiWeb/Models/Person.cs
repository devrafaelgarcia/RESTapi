using Primeiro.ApiWeb.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Models
{
    [Table("person")] //Trocamos o nome para oque está no banco
    public class Person : BaseEntity
    {

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("address")]
        public string Andress { get; set; }

        [Column("gender")]
        public string Gender { get; set; }
    }
}
