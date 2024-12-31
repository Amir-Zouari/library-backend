using Biblio.Data.Contexts;
using Biblio.Domain.Entities;
using Biblio.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Biblio.API.Controllers
{
    [Route("api/borrows")]
    [ApiController]
    public class BorrowController : ControllerBase
    {

        private readonly BorrowService borrowService;

        public BorrowController(BorrowService borrowService)
        {
            this.borrowService = borrowService;
        }

        [HttpPost]
        public string SaveBorrow(Borrow borrow)
        {
            borrowService.SaveBorrow(borrow);
            return "Borrow Added";
        }

        [HttpGet]
        [Route("{id}")]
        public Borrow GetBorrowById(int id)
        {
            return borrowService.GetBorrowById(id);
        }

        [HttpGet]
        public IEnumerable<Borrow> GetBorrows()
        {
            Debug.WriteLine("bachir keita");
            return borrowService.GetAllBorrows();
        }
    }
}
