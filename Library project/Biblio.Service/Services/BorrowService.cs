using Biblio.Data.Repositories;
using Biblio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Service.Services
{
    public class BorrowService
    {
        BorrowRepository borrowRepository;
        public BorrowService(BorrowRepository borrowRepository)
        {
            this.borrowRepository = borrowRepository;
        }

        public Borrow SaveBorrow(Borrow borrow)
        {
            borrowRepository.SaveBorrow(borrow);
            return borrow;
        }
        public Borrow GetBorrowById(int id)
        {
            return borrowRepository.GetBorrowById(id);
        }

        public IEnumerable<Borrow> GetAllBorrows()
        {
            return borrowRepository.GetAllBorrows();
        }
    }
}
