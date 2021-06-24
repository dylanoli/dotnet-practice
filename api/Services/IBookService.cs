
using System.Collections.Generic;
using api.Models;
using api.Repositories;
namespace api.Services
{
    public interface IBookService
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}