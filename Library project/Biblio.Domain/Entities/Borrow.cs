namespace Biblio.Domain.Entities
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        public Borrow(int id, DateTime date, DateTime dueDate, int userId)
        {
            Id = id;
            Date = date;
            UserId = userId;

        }

        public Borrow() { } // Empty constructor for flexibility
    }

}
