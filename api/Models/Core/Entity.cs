
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.Models.Core
{
    public abstract class Entity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}