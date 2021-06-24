using System.ComponentModel.DataAnnotations.Schema;
namespace api.Models
{
    [Table("person")]
    public class Person
    {
        public struct SGender
        {
            public const string MALE = "male";
            public const string FEMALE = "female";
        }

        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}