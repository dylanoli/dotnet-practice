using System.Collections.Generic;
using api.Models;
using api.Repositories.Core;

namespace api.Services
{
    public class PersonService : IPersonService
    {
        private IRepository<Person> _personRepository;
        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }
        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(long personId)
        {
            _personRepository.Delete(personId);
        }

        public List<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        public Person FindById(long personId)
        {
            return _personRepository.FindById(personId);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }
    }
}