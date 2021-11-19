using ecom.Data;
using ecom.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ecom.Controllers
{
    public class CartController : Controller
    {

        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public CartController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var cart = dbContext.Carts
                .Include(c => c.Items)
                .ThenInclude(i => i.ProductVariant)
                .ThenInclude(pv => pv.Product)
                .FirstOrDefault(c => c.ApplicationUserId == userId);
            if (cart == null)
            {
                cart = new Cart() { ApplicationUserId = userId, Items = new() };
                dbContext.Carts.Add(cart);
                dbContext.SaveChanges();
            }
            ViewData["TotalCost"] = cart.Items.Sum(i => i.ProductVariant.Price);
            return View(cart);
        }

        [Authorize]
        public IActionResult Add(int id)
        {
            var variant = dbContext.ProductVariants.FirstOrDefault(pv => pv.Id == id);
            if (variant == null)
                return NotFound();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var cart = dbContext.Carts
                .Include(c => c.Items)
                .FirstOrDefault(c => c.ApplicationUserId == userId);
            if (cart == null)
            {
                cart = new Cart() { ApplicationUserId = userId, Items = new() };
                dbContext.Carts.Add(cart);
                dbContext.SaveChanges();
            }
            cart.Items.Add(new CartItem() { ProductVariantId = id });
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult Remove(int id)
        {
            var cartItem = dbContext.CartItems.FirstOrDefault(ci => ci.Id == id);
            if (cartItem != null)
            {
                dbContext.CartItems.Remove(cartItem);
                dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
