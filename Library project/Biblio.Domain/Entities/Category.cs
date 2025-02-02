﻿namespace Biblio.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Category() { } // Empty constructor for flexibility
    }

}
