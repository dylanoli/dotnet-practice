using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("book")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("lauch_date")]
        public DateTime LauchDate { get; set; }
        [Column("price")]
        public float Price { get; set; }
    }
}