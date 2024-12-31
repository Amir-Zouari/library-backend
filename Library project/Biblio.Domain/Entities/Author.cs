namespace Biblio.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Description { get; set; }
        public string? Gender { get; set; }

        public Author(int id, string fullName, DateTime birthDate, string description, string gender)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            Description = description;
            Gender = gender;
            
        }

        public Author() { } // Empty constructor for flexibility
    }

}
