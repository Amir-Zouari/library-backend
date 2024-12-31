

namespace Biblio.Domain.Entities
{
    public class Tag
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public Tag() { }
        public Tag(int ID, string name)
        {
            Id = ID;
            Name = name;
        }
    }
}
