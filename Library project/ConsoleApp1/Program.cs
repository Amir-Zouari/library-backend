using Biblio.Data.Contexts;
using Biblio.Domain.Entities;

BiblioContext context = new BiblioContext();

var listCategories = new List<Category>{
                new Category{Name="Medicament" },
                new Category{Name="Vetement" },
                new Category{Name="Meuble" },
            };
context.Categories.AddRange(listCategories);
context.SaveChanges();

