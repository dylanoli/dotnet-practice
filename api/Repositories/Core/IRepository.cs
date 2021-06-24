using System.Collections.Generic;
using api.Models.Core;
namespace api.Repositories.Core
{
    public interface IRepository<T> where T : Entity
    {
        List<T> FindAll();

        T FindById(long id);

        T Create(T entity);

        void Delete(long id);

        T Update(T entity);
    }
}