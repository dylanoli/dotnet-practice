
using System.ComponentModel.DataAnnotations.Schema;
namespace api.Models.Core
{
    public abstract class Entity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}