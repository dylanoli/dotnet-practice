using api;
using System.Collections.Generic;
using System.Linq;
using api.Models;
namespace api.Repositories
{
    public class PersonRepository
    {
        private SqlContext _context = new SqlContext();
        public PersonRepository()
        {
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long personId)
        {
            return _context.Persons.SingleOrDefault(p => p.Id == personId);
        }

        public Person Create(Person person)
        {
            Person finalPerson = null;
            try
            {
                _context.Add(person);
                _context.SaveChanges();
                finalPerson = _context.Persons.LastOrDefault();
            }
            catch (System.Exception)
            {
                throw;
            }

            return finalPerson;
        }

        public void Delete(long personId)
        {
            var currentPerson = _context.Persons.SingleOrDefault(p => p.Id == personId);
            if (currentPerson != null)
            {
                try
                {
                    _context.Persons.Remove(currentPerson);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
            else
            {
                throw new System.Exception("Cannot find this person");
            }
        }

        public Person Update(Person person)
        {
            var currentPerson = _context.Persons.SingleOrDefault(p => p.Id == person.Id);
            if (currentPerson != null)
            {
                try
                {
                    _context.Entry(currentPerson).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }

                return person;
            }
            else
            {
                throw new System.Exception("Cannot find this person");
            }
        }
    }
}