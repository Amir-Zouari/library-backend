using Biblio.Data.Contexts;
using Biblio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Data.Repositories
{
    public class BorrowRepository
    {
        BiblioContext biblioContext;
        public BorrowRepository(BiblioContext biblioContext)
        {
            this.biblioContext = biblioContext;
        }

        public void SaveBorrow(Borrow borrow)
        {
            biblioContext.Borrows.Add(borrow);
            biblioContext.SaveChanges();
        }
        public Borrow GetBorrowById(int Id)
        {
            return biblioContext.Borrows
            .Include(b => b.User)
            .Include(b => b.CartItems)
            .ThenInclude(ci => ci.Book)
            .Where(b => b.Id == Id)
            .SingleOrDefault();
        }
        public IEnumerable<Borrow> GetAllBorrows()
        {
            return biblioContext.Borrows
                .Include(b => b.User)
                .Include(b => b.CartItems)
                .ThenInclude(ci => ci.Book)
                .ToList();
        }
    }
}
