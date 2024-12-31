namespace Biblio.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Language { get; set; }
        public string? Image { get; set; }
        public int? AvailableCopies { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Author>? Authors { get; set; }
        public int? PublisherId { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public virtual ICollection<Tag>? Tags { get; set; }

        public Book(int id, string iSBN, string title, string description, DateTime releaseDate, string language, string image,
            int availableCopies, int categoryId, Category category, ICollection<Author> authors, int publisherId, Publisher publisher, ICollection<Tag> tags)
        {
            Id = id;
            ISBN = iSBN;
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            Language = language;
            Image = image;
            AvailableCopies = availableCopies;
            CategoryId = categoryId;
            Category = category;
            Authors = authors;
            PublisherId = publisherId;
            Publisher = publisher;
            Tags = tags;
        }

        public Book() { } 
    }

}
