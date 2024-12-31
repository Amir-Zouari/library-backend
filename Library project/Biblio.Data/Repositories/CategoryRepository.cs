using Biblio.Data.Contexts;
using Biblio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Data.Repositories
{
    public class CategoryRepository
    {
        BiblioContext biblioContext;
        public CategoryRepository(BiblioContext biblioContext)
        {
            this.biblioContext = biblioContext;
        }
        public IEnumerable<Category> GetCategoryList()
        {

            return biblioContext.Categories.ToList();
        }
    }
}
