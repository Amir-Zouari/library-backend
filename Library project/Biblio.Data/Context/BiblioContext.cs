using Biblio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Data.Contexts
{
    public class BiblioContext : DbContext
    {

        public BiblioContext(DbContextOptions options) : base(options) // Ensure you have a connection string name
        {
            //Database.SetInitializer<BiblioContext>(new BiblioContextInitialize());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany()
                .HasForeignKey(b => b.CategoryId);
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany()
                .HasForeignKey(b => b.PublisherId);
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany();
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Tags)
                .WithMany();


            modelBuilder.Entity<Borrow>()
                .HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(b => b.UserId);
            modelBuilder.Entity<Borrow>()
                .HasMany(o => o.CartItems)
                .WithOne();


            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.Book)
                .WithMany()
                .HasForeignKey(c => c.BookId);


        }
    }
}
