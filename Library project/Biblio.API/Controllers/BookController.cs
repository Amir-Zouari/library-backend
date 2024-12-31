using Biblio.Data.Contexts;
using Biblio.Data.Repositories;
using Biblio.Domain.Entities;
using Biblio.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblio.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly BookService bookService;
        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return bookService.GetAllBooks();
        }

        [HttpGet]
        [Route("{id}")]
        public Book GetBooksById(int id)
        {
            return bookService.GetBookById(id);
        }
        [HttpGet]
        [Route("category")]
        public IEnumerable<Book> GetBooksByCategory([FromQuery] string name)
        {

            return bookService.GetBooksByCategory(name);
        }
        [HttpGet]
        [Route("tag")]
        public IEnumerable<Book> GetBooksByTag([FromQuery] string name)
        {
            return bookService.GetBooksByTag(name);
        }


    }
}
