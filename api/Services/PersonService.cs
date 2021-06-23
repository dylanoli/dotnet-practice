using System.Collections.Generic;
using api.Models;

namespace api.Services
{
    public class PersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long personId)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> personList = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                personList.Add(MockPerson(i));
            }
            return personList;
        }

        public Person FindById(long personId)
        {
            return MockPerson(personId);
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(long personId)
        {
            return new Person
            {
                Id = personId,
                Name = "Person " + personId,
                Age = (int)(30 - personId),
                Gender = personId % 2 == 0 ? Person.SGender.MALE : Person.SGender.FEMALE
            };
        }
    }
}