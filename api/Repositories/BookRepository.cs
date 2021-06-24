using System.Collections.Generic;
using api.Models;
using api.Repositories.Core;
using System.Linq;

namespace api.Repositories
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(SqlContext context) : base(context)
        {
        }
    }
}