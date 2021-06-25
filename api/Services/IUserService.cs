using System.Collections.Generic;
using api.Models;
using api.Repositories.Core;
using api.Services.Core;

namespace api.Services
{
    public interface IUserService
    {
        User Create(User user);

        void Delete(long id);

        List<User> FindAll();

        User FindById(long id);

        User Update(User user);
    }
}