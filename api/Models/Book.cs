using System;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models.Core;

namespace api.Models
{
    [Table("book")]
    public class Book : Entity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("lauch_date")]
        public DateTime LauchDate { get; set; }
        [Column("price")]
        public float Price { get; set; }
    }
}