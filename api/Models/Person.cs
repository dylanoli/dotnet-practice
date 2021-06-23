namespace api.Models
{
    public class Person
    {
        public struct SGender
        {
            public const string MALE = "male";
            public const string FEMALE = "female";
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}