using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using api.Models.Core;
using System.Linq;
namespace api.Repositories.Core
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private SqlContext _context;
        private DbSet<T> _dataset;
        public Repository(SqlContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(long id)
        {
            return _dataset.SingleOrDefault(p => p.Id == id);
        }

        public T Create(T entity)
        {
            T finalBook;
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                finalBook = _dataset.OrderBy(o => o.Id).LastOrDefault();
            }
            catch (System.Exception)
            {
                throw;
            }

            return finalBook;
        }

        public void Delete(long id)
        {
            var currentEntity = _dataset.SingleOrDefault(p => p.Id == id);
            if (currentEntity != null)
            {
                try
                {
                    _dataset.Remove(currentEntity);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
            else
            {
                throw new System.Exception("Cannot find this entity");
            }
        }

        public T Update(T entity)
        {
            var currentEntity = _dataset.SingleOrDefault(p => p.Id == entity.Id);
            if (currentEntity != null)
            {
                try
                {
                    _context.Entry(currentEntity).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }

                return entity;
            }
            else
            {
                throw new System.Exception("Cannot find this entity");
            }
        }
    }
}