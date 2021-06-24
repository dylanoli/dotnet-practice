using System.Collections.Generic;
using api.Models;
using api.Repositories.Core;

namespace api.Services
{
    public class BookService : IBookService
    {
        private IRepository<Book> _bookRepository;
        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _bookRepository.FindAll();
        }

        public Book FindById(long id)
        {
            return _bookRepository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}