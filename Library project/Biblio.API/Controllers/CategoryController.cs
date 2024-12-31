using Biblio.Domain.Entities;
using Biblio.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblio.API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly CategoryService categoryService;
        public CategoryController(CategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public IEnumerable<Category> GetAllCategories()
        {
            return categoryService.GetAllCategories();
        }
    }
}
