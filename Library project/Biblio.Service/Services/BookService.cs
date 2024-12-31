using Biblio.Data.Repositories;
using Biblio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Service.Services
{

    public class BookService
    {
        BookRepository bookRepository;

        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooksByCategory(string CategoryName)
        {
            return bookRepository.GetBooksByCategory(CategoryName);
        }
        public IEnumerable<Book> GetBooksByTag(string TagName)
        {
            return bookRepository.GetBooksByTag(TagName);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }




    }
}
