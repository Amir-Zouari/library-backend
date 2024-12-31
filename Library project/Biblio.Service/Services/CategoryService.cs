using Biblio.Data.Repositories;
using Biblio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Service.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;
        public CategoryService(CategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return categoryRepository.GetCategoryList();
        }
    }
}
