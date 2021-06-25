using api.Models;
using api.Repositories.Core;

namespace api.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SqlContext context) : base(context)
        {
        }
    }
}