namespace Biblio.Domain.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public Publisher(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public Publisher() { } // Empty constructor for flexibility
    }

}
