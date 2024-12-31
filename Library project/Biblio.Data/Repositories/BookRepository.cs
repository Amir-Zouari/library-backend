using Biblio.Data.Contexts;
using Biblio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Data.Repositories
{
    public class BookRepository
    {
        BiblioContext biblioContext;

        public BookRepository(BiblioContext biblioContext)
        {
            this.biblioContext = biblioContext;
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return biblioContext.Books
                .Include(b => b.Category)// Eager loading for Category
                .Include(b => b.Publisher)
                .Include(b => b.Authors)
                .Include(b => b.Tags)
                .ToList();

        }

        public Book GetBookById(int id)
        {
            return biblioContext.Books
            .Include(b => b.Category)
            .Include(b => b.Publisher)
            .Include(b => b.Authors)
            .Include(b => b.Tags)
            .Where(b => b.Id == id)
            .SingleOrDefault();
        }

        public IEnumerable<Book> GetBooksByCategory(string CategoryName)
        {
            return biblioContext.Books
            .Include(b => b.Category)
            .Include(b => b.Publisher)
            .Include(b => b.Authors)
            .Include(b => b.Tags)
            .Where(b => b.Category.Name == CategoryName)
            .ToList();

        }

        public IEnumerable<Book> GetBooksByTag(string TagName)
        {

            return biblioContext.Books
            .Include(b => b.Category)
            .Include(b => b.Publisher)
            .Include(b => b.Authors)
            .Include(b => b.Tags)
            .Where(b => b.Tags.Any(t => t.Name == TagName))
            .ToList();

        }



        public void Update(Book book)
        {
            throw new NotImplementedException();
        }


    }
}
