namespace Biblio.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }

        public User(int id, string fullName, DateTime birthDate, string gender)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public User() { } // Empty constructor for flexibility
    }

}
