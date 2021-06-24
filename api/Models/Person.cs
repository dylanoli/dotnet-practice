using System.ComponentModel.DataAnnotations.Schema;
using api.Models.Core;
namespace api.Models
{
    [Table("person")]
    public class Person : Entity
    {
        public struct SGender
        {
            public const string MALE = "male";
            public const string FEMALE = "female";
        }

        [Column("name")]
        public string Name { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}