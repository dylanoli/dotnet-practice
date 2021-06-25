using System.Collections.Generic;
using api.Models;
using api.Repositories.Core;
using api.Services.Core;

namespace api.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public User Create(User user)
        {
            return _repository.Create(user);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<User> FindAll()
        {
            return _repository.FindAll();
        }

        public User FindById(long id)
        {
            return _repository.FindById(id);
        }

        public User Update(User user)
        {
            return _repository.Update(user);
        }
    }
}