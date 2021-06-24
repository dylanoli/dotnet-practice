using System.Collections.Generic;
using api.Models;
using System.Linq;

namespace api.Repositories
{
    public class BookRepository
    {
        private SqlContext _context;
        public BookRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id == id);
        }

        public Book Create(Book book)
        {
            Book finalBook = null;
            try
            {
                _context.Add(book);
                _context.SaveChanges();
                finalBook = _context.Books.OrderBy(o => o.Id).LastOrDefault();
            }
            catch (System.Exception)
            {
                throw;
            }

            return finalBook;
        }

        public void Delete(long id)
        {
            var currentBook = _context.Books.SingleOrDefault(p => p.Id == id);
            if (currentBook != null)
            {
                try
                {
                    _context.Books.Remove(currentBook);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
            else
            {
                throw new System.Exception("Cannot find this person");
            }
        }

        public Book Update(Book book)
        {
            var currentBook = _context.Books.SingleOrDefault(p => p.Id == book.Id);
            if (currentBook != null)
            {
                try
                {
                    _context.Entry(currentBook).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }

                return book;
            }
            else
            {
                throw new System.Exception("Cannot find this book");
            }
        }
    }
}