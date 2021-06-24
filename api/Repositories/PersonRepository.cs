using api;
using System.Collections.Generic;
using System.Linq;
using api.Models;
using api.Repositories.Core;
namespace api.Repositories
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(SqlContext context) : base(context)
        {
        }
    }
}