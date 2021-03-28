using System.ComponentModel.DataAnnotations.Schema;

namespace Primeiro.ApiWeb.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
