using Microsoft.EntityFrameworkCore;
using api.Models;
namespace api
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}