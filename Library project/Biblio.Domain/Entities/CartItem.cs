using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public DateTime? DueDate { get; set; }
        public int? BookId { get; set; }
        public virtual Book ? Book { get; set; }
        public CartItem() { }
        public CartItem(int id, DateTime dueDate, int bookId, Book book)
        {
            Id = id;
            DueDate = dueDate;
            BookId = bookId;
            Book = book;
        }
    }
}
