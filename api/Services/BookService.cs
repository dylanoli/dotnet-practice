using System.Collections.Generic;
using api.Models;
using api.Repositories;

namespace api.Services
{
    public class BookService : IBookService
    {
        private BookRepository _bookRepository;
        public BookService(BookRepository bookRepository)
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