using ecom.Data;
using ecom.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecom.Controllers
{

    public class HomeViewModel
    {
        public IQueryable<Product> TopProducts;
        public IQueryable<Category> OtherCategories;
    }

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var topProducts =
                dbContext.Products
                .Include(p => p.Category)
                .OrderByDescending(
                    p => dbContext.OrderItems
                    .Include(oi => oi.ProductVariant)
                    .Where(oi => oi.ProductVariant.ProductId == p.Id)
                    .Count()
                ).Take(3);
            var topProductCategoryIds = topProducts.Select(p => p.CategoryId);
            var otherCategories =
                dbContext.Categories
                .Include(c => c.Products.Take(5))
                .Where(c => !topProductCategoryIds
                .Contains(c.Id))
                .AsNoTracking();
            HomeViewModel model = new()
            {
                TopProducts = topProducts,
                OtherCategories = otherCategories
            };
            return View(model);
        }

        public async Task<IActionResult> Search(string searchString)
        {
            ViewData["SearchString"] = searchString;
            var products = from p in dbContext.Products select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products
                    .Include(p => p.Category)
                    .Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
            }
            return View(await products.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}