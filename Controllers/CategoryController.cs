using ecom.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecom.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET /Category/Detail/:id
        public IActionResult Detail(int id)
        {
            var category = dbContext.Categories
                .Include(c => c.Products)
                .FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return View(category);
        }
    }
}
